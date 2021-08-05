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

	testQuestions: Question[] = [];

	constructor(public submit: SubmitTestService) {}

	addDataHandleClick(choise: any): void {
		const currentAnswer: testAnswer = {
			// id: this.question.id,
			passedTestId: 0,
			questionId: this.question.id,
			answer: choise
		};
		this.submit.addData(this.question.id, currentAnswer);
		const allButtons = document.querySelectorAll('[type=button]');
		allButtons[this.currentIndex].classList.add('nav-btn-activated');
	}
}
