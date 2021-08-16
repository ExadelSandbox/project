import { Component, DoCheck, Input } from '@angular/core';
import { Question, testAnswer } from '../../interfaces/interfaces';
import SubmitTestService from '../../services/submit-test.service';

@Component({
	selector: 'app-question',
	templateUrl: './question.component.html',
	styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements DoCheck {
	@Input() question: Question;
	@Input() testPassedId: number;
	@Input() currentIndex: number;

	public testQuestions: Question[] = [];
	public navButtons: any;

	constructor(public submit: SubmitTestService) {}

	ngDoCheck() {
		this.navButtons = document.querySelectorAll('.nav-btn');
	}

	addDataHandleClick(choise: Question): void {
		const currentAnswer: testAnswer = {
			id: 0,
			passedTestId: this.testPassedId,
			questionId: this.question.id,
			reportId: null,
			answer: choise.text,
			assessment: 0
		};
		this.navButtons[this.currentIndex].classList.add('nav-btn-completed');
		this.submit.addData(this.question.id, currentAnswer);
	}
}
