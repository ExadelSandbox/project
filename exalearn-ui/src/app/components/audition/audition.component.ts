import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { StreamState } from '../../interfaces/stream-state';
import { AuditionService } from '../../services/audition.service';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';

@Component({
	selector: 'app-audition',
	templateUrl: './audition.component.html',
	styleUrls: ['./audition.component.scss'],
	encapsulation: ViewEncapsulation.None
})
export class AuditionComponent implements OnInit {
	files: Array<any> = [];
	state: StreamState | undefined;
	currentFile: any = {};
	testQuestions: Question[] = [];
	currentAttempts = 0;
	ATTEMPTS_NUMBER = 3;

	constructor(private audioService: AuditionService, private cloudService: AudioCloudService) {}

	ngOnInit() {
		this.testQuestions = questions;

		this.cloudService.getFiles().subscribe((files) => {
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
		if (this.currentAttempts < 3) {
			this.currentAttempts++;
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
