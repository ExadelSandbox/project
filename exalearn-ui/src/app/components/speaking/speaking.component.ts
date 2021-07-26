import { Component, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment.prod';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { MediaRecorder } from 'extendable-media-recorder';

// declare const MediaRecorder: any;

@Component({
	selector: 'app-speaking',
	templateUrl: './speaking.component.html',
	styleUrls: ['./speaking.component.scss']
})
export class SpeakingComponent implements OnInit {
	public topic = 'What is happiness?';
	private mediaRecorder: any;
	private chunks: Blob[] = [];

	readonly recordingDuration: number = 5 * 6000;
	recording: boolean;
	recorder: Promise<MediaStream>;

	constructor(private audioStorage: AudioCloudService) {}

	ngOnInit(): void {
		this.recording = false;
	}

	startRecording(): void {
		this.recorder = navigator.mediaDevices.getUserMedia({ audio: true });
		void this.recorder.then((stream) => {
			this.mediaRecorder = new MediaRecorder(stream);
			this.recording = true;
			this.mediaRecorder.start(this.recordingDuration);
			if (this.recording) {
				setTimeout(() => this.stopRecording(), this.recordingDuration);
			}
			this.getData();
			this.creatAudio();
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
			void audio.play();
			this.pushAudioToCloudService();
		};
	}
	pushAudioToCloudService(): void {
		const file = new File(this.chunks, 'recording.webm');
		this.audioStorage.pushFileToStorage(file, environment.cloudSpeaking).subscribe(
			// (percentage) => {},
			null,
			// (error) => {
			// 	console.log(error);
			// },
			null,
			() => {
				setTimeout(() => {
					console.log(this.audioStorage.getURL());
				}, 2000);
			}
		);
	}
	stopRecording(): void {
		if (this.recording) {
			this.recording = false;
			this.mediaRecorder.stop();
		}
	}
}
