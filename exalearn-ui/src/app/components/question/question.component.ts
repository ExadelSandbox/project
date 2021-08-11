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
			isCorrect: choise.isCorrect,
			assessment: 0
		};
		this.submit.addData(this.question.id, currentAnswer);
	}
}
