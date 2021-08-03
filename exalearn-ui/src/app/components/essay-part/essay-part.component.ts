import { Component, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	themeEssay = 'How I spent summer';
	fillingEssay = 512;
	textEssay: string;

	constructor(public submit: SubmitTestService) {}

	ngOnInit(): void {}

	inputHandler(value: string) {
		this.textEssay = value;
		const essayAnswer = {
			theme: this.themeEssay,
			text: this.textEssay
		};
		this.submit.addData('essay', essayAnswer);
	}
}
