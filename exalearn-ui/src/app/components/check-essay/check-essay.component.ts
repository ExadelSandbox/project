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

	ngOnInit(): void {}
}
