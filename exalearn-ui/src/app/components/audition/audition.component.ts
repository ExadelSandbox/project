import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { Question } from '../../interfaces/interfaces';

@Component({
	selector: 'app-audition',
	templateUrl: './audition.component.html',
	styleUrls: ['./audition.component.scss'],
	encapsulation: ViewEncapsulation.None
})
export class AuditionComponent implements OnInit {
	@Input() questionsAudio: Question[];
	testQuestions: Question[] = [];

	ngOnInit() {
		this.testQuestions = this.questionsAudio;
	}
}
