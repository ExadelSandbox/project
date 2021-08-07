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
	@Input() currentIndex: number;
	@Input() testPassedId: number;

	testQuestions: Question[] = [];

	constructor(public submit: SubmitTestService) {}

	addDataHandleClick(choise: any): void {
		const currentAnswer: testAnswer = {
			passedTestId: this.testPassedId,
			questionId: this.question.id,
			answer: choise.text
		};

		this.submit.addData(this.question.id, currentAnswer);
	}
}
