import { Component, OnInit } from '@angular/core';
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
	file: Array<any> = [0];
	index = 0;

	// eslint-disable-next-line no-unused-vars
	constructor(private audioService: AuditionService, cloudService: CloudService) {
		// get media files
		cloudService.getFiles().subscribe((files) => {
			this.files = files;
		});

		// listen to stream state
		this.audioService.getState().subscribe((state) => {
			this.state = state;
		});
	}

	// @ts-ignore
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	playStream(url) {
		this.audioService.playStream(url).subscribe((events) => {});
	}

	// @ts-ignore
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	openFile(file, index) {
		this.currentFile = { index, file };
		this.audioService.stop();
		this.playStream(file.url);
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	pause() {
		this.audioService.pause();
	}

	// @ts-ignore
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	play() {
		this.audioService.play();
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	stop() {
		this.audioService.stop();
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	next() {
		// eslint-disable-next-line @typescript-eslint/restrict-plus-operands
		const index = this.currentFile.index + 1;
		const file = this.files[index];
		this.openFile(file, index);
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	previous() {
		const index = this.currentFile.index - 1;
		const file = this.files[index];
		this.openFile(file, index);
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	isFirstPlaying() {
		return this.currentFile.index === 0;
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	isLastPlaying() {
		return this.currentFile.index === this.files.length - 1;
	}

	// @ts-ignore
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	onSliderChangeEnd(change) {
		this.audioService.seekTo(change.value);
	}

	// eslint-disable-next-line @typescript-eslint/no-empty-function
	ngOnInit(): void {}
}
