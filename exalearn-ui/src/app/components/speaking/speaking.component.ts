import { Component, Input, OnInit } from '@angular/core';
import { AudioFile } from '../../interfaces/interfaces';

@Component({
	selector: 'app-speaking',
	templateUrl: './speaking.component.html',
	styleUrls: ['./speaking.component.scss']
})
export class SpeakingComponent {
	@Input() audio: AudioFile;

	declare MediaRecorder: any;
	topic: string = 'What is happiness?';

	getConstraint(): void {
		const constraints: any = { audio: true };
		navigator.mediaDevices
			.getUserMedia(constraints)
			.then(function (stream) {
				const mediaRecorder = new MediaRecorder(stream);
				let audio = document.querySelector('audio');
				audio.srcObject = stream;
				audio.onloadedmetadata = function () {
					audio.play();
					audio.muted = true;
				};
			})
			.catch(function (err) {
				console.log(false);
			});
	}
}
