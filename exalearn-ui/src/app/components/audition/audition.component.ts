import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { StreamState } from '../../interfaces/stream-state';
import { AuditionService } from '../../services/audition.service';
import { CloudService } from '../../services/cloud.service';
import { Question } from 'src/app/interfaces/interfaces';

@Component({
	selector: 'app-audition',
	templateUrl: './audition.component.html',
	styleUrls: ['./audition.component.scss']
})
export class AuditionComponent implements OnInit {
	questions: Question[] = [
		{
			id: 1234,
			questionText: 'Her thinking leans ____ democracy',
			choices: ['with', 'towards', 'for', 'None of these'],
			userAnswer: null,
			index: undefined
		},
		{
			id: 1123,
			questionText: 'He got too tired _____ over work.',
			choices: ['because of', 'because off', 'on', 'for'],
			userAnswer: null,
			index: undefined
		},
		{
			id: 23321,
			questionText: '_____ his principles, he has to be very careful.',
			choices: ['with regard of', 'with regard on', 'with regard to', 'None of these'],
			userAnswer: null,
			index: undefined
		}
	];
	currentIndex = 0;

	files: Array<any> = [];
	state: StreamState | undefined;
	currentFile: any = {};
	NumberOfAttempts = 0;

	// eslint-disable-next-line no-unused-vars
	constructor(private audioService: AuditionService, cloudService: CloudService) {
		cloudService.getFiles().subscribe((files) => {
			this.files = files;
		});

		this.audioService.getState().subscribe((state) => {
			this.state = state;
		});
	}

	// @ts-ignore
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	playStream(url) {
		this.audioService.playStream(url).subscribe((events) => {});
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	pause() {
		this.audioService.pause();
	}

	// @ts-ignore
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	play(file, index) {
		if (this.NumberOfAttempts < 3) {
			this.NumberOfAttempts++;
			this.currentFile = { index, file };
			this.playStream(file.url);
			this.audioService.play();
		} else {
			alert('The number of attempts has ended ');
		}
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	stop() {
		this.audioService.stop();
	}

	// @ts-ignore
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	onSliderChangeEnd(change) {
		this.audioService.seekTo(change.value);
	}

	// audioEnded(): void {
	// 	console.log('ended!!');
	// }

	// eslint-disable-next-line @typescript-eslint/no-empty-function
	ngOnInit(): void {}
}
