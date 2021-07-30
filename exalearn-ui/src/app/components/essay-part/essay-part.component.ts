import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	themeEssay = 'How I spent summer';
	fillingEssay = 512;
	textEssay: string;

	mapOfEssay = new Map();

	ngOnInit(): void {}

	inputHandler(value: string) {
		this.textEssay = value;
		const essayAnswer = {
			theme: this.themeEssay,
			text: this.textEssay
		};
		this.mapOfEssay.set('essay', essayAnswer);
		console.log(this.mapOfEssay);
	}
}
