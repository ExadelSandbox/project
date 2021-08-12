import { Component, Input, OnInit } from '@angular/core';
import { ToasterConfig } from 'angular2-toaster';
import { environment } from '../../../environments/environment.prod';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { MediaRecorder } from 'extendable-media-recorder';
import { TimerService } from '../../services/timer.service';
import { Subscription } from 'rxjs';
import SubmitTestService from '../../services/submit-test.service';
import { testAnswer, Topic } from '../../interfaces/interfaces';
import { NotificationService } from '../../services/notification.service';
import { configPopUp } from '../../services/notification.service';

@Component({
	selector: 'app-speaking',
	templateUrl: './speaking.component.html',
	styleUrls: ['./speaking.component.scss']
})
export class SpeakingComponent implements OnInit {
	@Input() questionsSpeaking: any;
	@Input() testPassedId: number;

	topic: Topic;
	public recording: boolean;
	public recorder: Promise<MediaStream>;
	public speakingTimerStarted: boolean;
	public resetSpeakingTimer: boolean;
	public speakingTimer: number;
	public innerText = 'Recording:';
	public timerSubscriber: Subscription;
	public audioUrlCloud: string;
	public configPop: ToasterConfig;

	private mediaRecorder: any;
	private chunks: Blob[] = [];
	public isDataAvailable: boolean;
	public isRecordReadySpinner = false;
	readonly recordingDuration: number = 5 * 60000;

	public audioLink: string;

	constructor(
		private audioStorage: AudioCloudService,
		private timerService: TimerService,
		public submit: SubmitTestService,
		private notificationService: NotificationService
	) {
		this.configPop = configPopUp;
	}

	ngOnInit(): void {
		if (this.questionsSpeaking.length === 0) {
			this.isDataAvailable = false;
		} else {
			this.recording = false;
			this.speakingTimerStarted = false;
			this.resetSpeakingTimer = false;
			this.speakingTimer = this.timerService.speakingTimer;
			this.audioUrlCloud = '';
			this.topic = this.questionsSpeaking;
			this.isDataAvailable = true;
		}
	}

	startRecording(): void {
		this.recorder = navigator.mediaDevices.getUserMedia({ audio: true });
		void this.recorder.then((stream) => {
			this.mediaRecorder = new MediaRecorder(stream);
			this.speakingTimerStarted = true;
			this.recording = true;
			this.mediaRecorder.start(this.recordingDuration);
			this.getData();
			if (this.audioUrlCloud != '') {
				this.deleteAudioFromCloudService();
			}
			this.timerSubscribe();
		});
	}

	stopRecording(): void {
		if (this.recording) {
			this.speakingTimerStarted = false;
			this.resetSpeakingTimer = false;
			this.recording = false;
			this.mediaRecorder.stop();
			this.createAudio();
		}
		this.timerSubscriber.unsubscribe();
	}

	getData(): void {
		this.chunks = [];
		this.mediaRecorder.ondataavailable = (event: any) => {
			this.chunks.push(event.data);
		};
	}

	createAudio(): void {
		this.mediaRecorder.onstop = async () => {
			const audioBlob = new Blob(this.chunks, { type: 'audio/webm; codecs=opus' });
			const audioUrl = URL.createObjectURL(audioBlob);
			const audio = new Audio(audioUrl);
			await this.pushAudioToCloudService();
		};
	}

	timerSubscribe(): void {
		this.timerSubscriber = this.timerService.timerObservable.subscribe((count) => {
			count && this.stopRecording();
		});
	}

	async pushAudioToCloudService(): Promise<void> {
		const file = new File(this.chunks, 'recording.webm');
		this.isDataAvailable = true;
		this.isRecordReadySpinner = true;
		await this.audioStorage
			.uploadAudio(file, environment.cloudSpeaking)
			.then((url) => {
				this.audioUrlCloud = url;
				this.isRecordReadySpinner = false;
				this.recording = false;
				const speakingAnswer: testAnswer = {
					id: 0,
					passedTestId: this.testPassedId,
					questionId: this.topic.id,
					reportId: null,
					answer: this.audioUrlCloud,
					assessment: 0
				};
				this.submit.addData('speaking', speakingAnswer);
			})
			.catch(() => {
				this.notificationService.errorPopUp('Something wrong. Try again!');
				this.isRecordReadySpinner = true;
				this.recording = false;
			});
	}

	deleteAudioFromCloudService(): void {
		this.audioStorage.deleteAudio(this.audioUrlCloud);
	}
}
