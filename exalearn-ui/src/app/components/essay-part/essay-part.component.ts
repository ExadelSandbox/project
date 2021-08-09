import { Component, Input, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { testAnswer, Topic } from '../../interfaces/interfaces';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	@Input() questionsEssay: any;

	themeEssay: Topic;
	fillingEssay = 512;
	textEssay: string;
	public isDataAvailable: boolean;

	constructor(public submit: SubmitTestService) {}

	ngOnInit(): void {
		if (this.questionsEssay.length === 0) {
			this.isDataAvailable = false;
		} else {
			this.themeEssay = this.questionsEssay;
			this.isDataAvailable = true;
		}
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
