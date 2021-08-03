import { Component, Input, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment.prod';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { MediaRecorder } from 'extendable-media-recorder';
import { TimerService } from '../../services/timer.service';
import { Subscription } from 'rxjs';
import SubmitTestService from '../../services/submit-test.service';

@Component({
	selector: 'app-speaking',
	templateUrl: './speaking.component.html',
	styleUrls: ['./speaking.component.scss']
})
export class SpeakingComponent implements OnInit {
	@Input() questionsSpeaking: string;

	// public topic = 'What is happiness?';
	topic: string;
	public recording: boolean;
	public recorder: Promise<MediaStream>;
	public speakingTimerStarted: boolean;
	public resetSpeakingTimer: boolean;
	public speakingTimer: number;
	public innerText = 'Recording:';
	public timerSubscriber: Subscription;
	public audioURL: string;

	private mediaRecorder: any;
	private chunks: Blob[] = [];
	readonly recordingDuration: number = 5 * 60000;

	public audioLink: string;

	constructor(
		private audioStorage: AudioCloudService,
		private timerService: TimerService,
		public submit: SubmitTestService
	) {}

	ngOnInit(): void {
		this.recording = false;
		this.speakingTimerStarted = false;
		this.resetSpeakingTimer = false;
		this.speakingTimer = this.timerService.speakingTimer;
		this.topic = this.questionsSpeaking;
	}

	startRecording(): void {
		this.recorder = navigator.mediaDevices.getUserMedia({ audio: true });
		void this.recorder.then((stream) => {
			this.mediaRecorder = new MediaRecorder(stream);
			this.speakingTimerStarted = true;
			this.recording = true;
			this.mediaRecorder.start(this.recordingDuration);
			this.getData();
			this.creatAudio();
			this.timerSubscribe();
		});
	}

	getData(): void {
		this.chunks = [];
		this.mediaRecorder.ondataavailable = (event: any) => {
			this.chunks.push(event.data);
		};
	}

	creatAudio(): void {
		this.mediaRecorder.onstop = () => {
			const audioBlob = new Blob(this.chunks, { type: 'audio/webm; codecs=opus' });
			const audioUrl = URL.createObjectURL(audioBlob);
			const audio = new Audio(audioUrl);
			this.pushAudioToCloudService();
		};
	}

	timerSubscribe(): void {
		this.timerSubscriber = this.timerService.timerObservable.subscribe((count) => {
			count && this.stopRecording();
		});
	}

	pushAudioToCloudService(): void {
		const file = new File(this.chunks, 'recording.webm');
		this.audioStorage.uploadAudio(file, environment.cloudSpeaking).then((url) => {
			this.audioURL = url;
			const speakingAnswer = {
				link: this.audioURL
			};
			this.submit.addData('speaking', speakingAnswer);
		});
	}

	stopRecording(): void {
		if (this.recording) {
			this.speakingTimerStarted = false;
			this.resetSpeakingTimer = false;
			this.recording = false;
			this.mediaRecorder.stop();
		}
		this.timerSubscriber.unsubscribe();
	}
}
