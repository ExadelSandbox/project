import { Component, Input, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { Question } from '../../interfaces/interfaces';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	@Input() questionsEssay: string;

	// themeEssay = 'How I spent summer';
	themeEssay: string;
	fillingEssay = 512;
	textEssay: string;

	constructor(public submit: SubmitTestService) {}

	ngOnInit(): void {
		this.themeEssay = this.questionsEssay;
	}

	inputHandler(value: string) {
		this.textEssay = value;
		const essayAnswer = {
			theme: this.themeEssay,
			text: this.textEssay
		};
		this.submit.addData('essay', essayAnswer);
	}
}
