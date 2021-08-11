import { Component, Input } from '@angular/core';
import { Question, testAnswer } from '../../interfaces/interfaces';
import SubmitTestService from '../../services/submit-test.service';

@Component({
	selector: 'app-question',
	templateUrl: './question.component.html',
	styleUrls: ['./question.component.scss']
})
export class QuestionComponent {
	@Input() question: Question;
	@Input() testPassedId: number;
	@Input() currentIndex: number;

	testQuestions: Question[] = [];

	constructor(public submit: SubmitTestService) {}

	addDataHandleClick(choise: Question): void {
		const currentAnswer: testAnswer = {
			id: 0,
			passedTestId: this.testPassedId,
			questionId: this.question.id,
			reportId: null,
			answer: choise.text,
			assessment: 0
		};
		console.log(this.question);
		this.submit.addData(this.question.id, currentAnswer);
	}
}
