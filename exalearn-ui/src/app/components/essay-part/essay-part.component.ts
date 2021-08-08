import { Component, Input, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { testAnswer } from '../../interfaces/interfaces';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	@Input() questionsEssay: any;

	themeEssay: string | any;
	fillingEssay = 512;
	textEssay: string;

	constructor(public submit: SubmitTestService) {}

	ngOnInit(): void {
		this.themeEssay = this.questionsEssay;
	}

	inputHandler(value: string) {
		this.textEssay = value;
		const essayAnswer: testAnswer = {
			questionId: this.themeEssay.id,
			answer: this.textEssay
		};
		this.submit.addData('essay', essayAnswer);
	}
}
