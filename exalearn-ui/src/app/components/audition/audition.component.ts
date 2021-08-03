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
	testQuestions: Question[] = [];
	audioUrl: string;

	constructor(private cloudService: AudioCloudService) {}

	ngOnInit() {
		this.testQuestions = this.questionsAudio;
		this.cloudService.setFiles(this.questionsAudio[0].url);
	}
}
