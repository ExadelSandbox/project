import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';

@Component({
	selector: 'app-audition',
	templateUrl: './audition.component.html',
	styleUrls: ['./audition.component.scss'],
	encapsulation: ViewEncapsulation.None
})
export class AuditionComponent implements OnInit {
	testQuestions: Question[] = [];

	ngOnInit() {
		this.testQuestions = questions;
	}
}
