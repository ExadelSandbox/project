import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	textEssay: string;
	themeEssay = 'How I spent summer';
	fillingEssay = 512;

	ngOnInit(): void {}

	inputHandler(value: string) {
		this.textEssay = value;
	}
}
