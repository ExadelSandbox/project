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
	files: Array<any> = [];
	state: StreamState = {};
	currentFile: any = {};

	questions: Question[] = [
		{
			id: 0,
			questionText: 'Her thinking leans ____ democracy',
			choices: ['with', 'towards', 'for', 'None of these'],
			userAnswer: null
		},
		{
			id: 1,
			questionText: 'He got too tired _____ over work.',
			choices: ['because of', 'because off', 'on', 'for'],
			userAnswer: null
		},
		{
			id: 2,
			questionText: '_____ his principles, he has to be very careful.',
			choices: ['with regard of', 'with regard on', 'with regard to', 'None of these'],
			userAnswer: null
		}
	];
	currentId = 0;

	constructor(private audioService: AuditionService, cloudService: CloudService) {
		cloudService.getFiles().subscribe((files) => {
			this.files = files;
		});

		this.audioService.getState().subscribe((state) => {
			this.state = state;
		});
	}

	ngOnInit(): void {
		throw new Error('Method not implemented.');
	}

	//NOT READY LEHAI
	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	playStream(url: string) {
		// eslint-disable-next-line @typescript-eslint/no-empty-function
		this.audioService.playStream(url).subscribe((events) => {});
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	openFile(file: any, index: any) {
		this.currentFile = { index, file };
		this.audioService.stop();
		this.playStream(file.url);
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	pause() {
		this.audioService.pause();
	}

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

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	onSliderChangeEnd(change: any) {
		this.audioService.seekTo(change.value);
	}
}
