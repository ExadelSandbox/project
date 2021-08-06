import { Component, Input, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { Question, testAnswer } from '../../interfaces/interfaces';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	@Input() questionsEssay: any;
	@Input() passedTestId: number;

	themeEssay: string | any;
	fillingEssay = 512;
	textEssay: string;
	public passTestId: number;

	constructor(public submit: SubmitTestService) {}

	ngOnInit(): void {
		this.themeEssay = this.questionsEssay;
		this.passTestId = this.passedTestId;
	}

	inputHandler(value: string) {
		this.textEssay = value;
		const essayAnswer: testAnswer = {
			questionId: this.themeEssay.id,
			passedTestId: 0,
			answer: this.textEssay
		};
		this.submit.addData('essay', essayAnswer);
	}
}
