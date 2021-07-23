import { Component, OnInit } from '@angular/core';

declare const MediaRecorder: any;

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
				this.chunks.push(event.data);
			};

			this.mediaRecorder.onstop = () => {
				const audioBlob = new Blob(this.chunks);
				const audioUrl = URL.createObjectURL(audioBlob);
				const audio = new Audio(audioUrl);
				void audio.play();
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
