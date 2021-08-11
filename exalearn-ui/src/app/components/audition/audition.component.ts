import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { Question } from '../../interfaces/interfaces';
import { AudioCloudService } from '../../services/audio-cloud.service';

@Component({
	selector: 'app-audition',
	templateUrl: './audition.component.html',
	styleUrls: ['./audition.component.scss'],
	encapsulation: ViewEncapsulation.None
})
export class AuditionComponent implements OnInit {
	@Input() questionsAudio: Question[];
	@Input() testPassedId: number;

	testQuestions: Question[] = [];
	audioUrl: string;
	public isDataAvailable: boolean;

	constructor(private cloudService: AudioCloudService) {}

	ngOnInit() {
		if (this.questionsAudio.length === 0) {
			this.isDataAvailable = false;
		} else {
			this.testQuestions = this.questionsAudio;
			this.cloudService.setFiles(this.questionsAudio[0].url);
			this.isDataAvailable = true;
		}
	}
}
