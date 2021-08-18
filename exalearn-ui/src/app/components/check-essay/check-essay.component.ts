import { Component, Input, OnInit } from '@angular/core';

@Component({
	selector: 'app-check-essay',
	templateUrl: './check-essay.component.html',
	styleUrls: ['./check-essay.component.scss']
})
export class CheckEssayComponent implements OnInit {
	textEssay = 'Test';
	themeEssay = 'My Hobby';
	fillingEssay = 512;
	essayMark = 1;

	ngOnInit(): void {}

	setMark(mark: number): void {
		this.essayMark = mark;
	}
}
