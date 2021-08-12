import { Component, OnInit } from '@angular/core';
import { ToasterConfig } from 'angular2-toaster';
import { Subscription } from 'rxjs';
import { environment } from '../../../environments/environment.prod';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { MediaRecorder } from 'extendable-media-recorder';
import { TimerService } from '../../services/timer.service';
import { NotificationService } from '../../services/notification.service';
import { configPopUp } from '../../services/notification.service';

@Component({
	selector: 'app-speaking',
	templateUrl: './speaking.component.html',
	styleUrls: ['./speaking.component.scss']
})
export class SpeakingComponent implements OnInit {
	public topic = 'What is happiness?';
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
	public isDataAvailable = false;
	readonly recordingDuration: number = 5 * 60000;

	constructor(
		private audioStorage: AudioCloudService,
		private timerService: TimerService,
		private notificationService: NotificationService
	) {
		this.configPop = configPopUp;
	}

	ngOnInit(): void {
		this.recording = false;
		this.speakingTimerStarted = false;
		this.resetSpeakingTimer = false;
		this.speakingTimer = this.timerService.speakingTimer;
		this.audioUrlCloud = '';
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
		await this.audioStorage
			.uploadAudio(file, environment.cloudSpeaking)
			.then((url) => {
				this.audioUrlCloud = url;
			})
			.catch(() => {
				this.notificationService.errorPopUp('Something wrong. Try again!');
			})
			.finally(() => {
				this.isDataAvailable = false;
				this.recording = false;
			});
	}

	deleteAudioFromCloudService(): void {
		this.audioStorage.deleteAudio(this.audioUrlCloud);
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
}
