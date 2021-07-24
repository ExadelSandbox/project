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

	readonly recordingDuration: number = 300000;
	recording: boolean;
	recorder: Promise<MediaStream>;

	constructor(private audioStorage: AudioCloudService) {}

	ngOnInit(): void {
		this.recorder = navigator.mediaDevices.getUserMedia({ audio: true });
		this.recording = false;
	}

	startRecording(): void {
		void this.recorder.then((stream) => {
			this.mediaRecorder = new MediaRecorder(stream);
			this.recording = true;
			this.mediaRecorder.start(this.recordingDuration);
			console.log(this.mediaRecorder.mimeType);

			this.chunks = [];
			this.mediaRecorder.ondataavailable = (event: any) => {
				console.log(this.chunks.length);
				console.log(this.chunks);
				this.chunks.push(event.data);
			};

			this.mediaRecorder.onstop = () => {
				const audioBlob = new Blob(this.chunks, { type: 'audio/webm; codecs=opus' });
				const file = new File(this.chunks, 'recording.webm');
				const audioUrl = URL.createObjectURL(audioBlob);
				const audio = new Audio(audioUrl);
				void audio.play();
				this.audioStorage.pushFileToStorage(file, environment.cloudSpeaking).subscribe(
					(percentage) => {},
					(error) => {
						console.log(error);
					},
					() => {
						setTimeout(() => {
							console.log(this.audioStorage.getURL());
						}, 2000);
					}
				);
				console.log(audioUrl);
				console.log(audioBlob);
			};
		});
	}

	stopRecording(): void {
		if (this.recording) {
			this.recording = false;

			this.mediaRecorder.stop();
		}
	}
}
