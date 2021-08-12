import { Component, Input, OnInit } from '@angular/core';
import { CheckQuestion } from '../../interfaces/interfaces';
import { checkQuestions } from '../../test-data/test-questions';

@Component({
	selector: 'app-check-question',
	templateUrl: './check-question.component.html',
	styleUrls: ['./check-question.component.scss']
})
export class CheckQuestionComponent implements OnInit {
	@Input() question: CheckQuestion;
	testQuestions: CheckQuestion[] = [];

	ngOnInit() {
		this.testQuestions = checkQuestions;
	}
}
