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

	ngOnInit(): void {}

	inputHandler(value: string) {
		this.textEssay = value;
	}
}
