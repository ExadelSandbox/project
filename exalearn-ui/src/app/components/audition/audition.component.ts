import { Component, Input, ViewEncapsulation } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { StreamState } from '../../interfaces/stream-state';
import { AuditionService } from '../../services/audition.service';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { Question } from 'src/app/interfaces/interfaces';

@Component({
	selector: 'app-audition',
	templateUrl: './audition.component.html',
	styleUrls: ['./audition.component.scss'],
	encapsulation: ViewEncapsulation.None
})
export class AuditionComponent {
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

	constructor(private audioService: AuditionService, cloudService: AudioCloudService) {
		cloudService.getFiles().subscribe((files) => {
			this.files = files;
		});

		this.audioService.getState().subscribe((state) => {
			this.state = state;
		});
	}

	playStream(url: string) {
		this.audioService.playStream(url).subscribe((events) => {});
	}

	pause() {
		this.audioService.pause();
	}

	play(file: any, index: number) {
		if (this.NumberOfAttempts < 3) {
			this.NumberOfAttempts++;
			this.currentFile = { index, file };
			this.playStream(file.url);
			this.audioService.play();
		} else {
			alert('The number of attempts has ended ');
		}
	}

	stop() {
		this.audioService.stop();
	}

	onSliderChangeEnd(change: any) {
		this.audioService.seekTo(change.value);
	}
}
