import { Component, Input, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { Question, testAnswer } from '../../interfaces/interfaces';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	@Input() questionsEssay: string;

	themeEssay: string;
	fillingEssay = 512;
	textEssay: string;

	constructor(public submit: SubmitTestService) {}

	ngOnInit(): void {
		this.themeEssay = this.questionsEssay;
	}

	inputHandler(value: string) {
		this.textEssay = value;
		const essayAnswer: testAnswer = {
			// id: 0,
			passedTestId: 0,
			questionId: this.themeEssay,
			answer: this.textEssay
		};
		this.submit.addData('essay', essayAnswer);
	}
}
