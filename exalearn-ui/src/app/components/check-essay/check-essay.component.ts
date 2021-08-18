import { Component, Input, OnInit } from '@angular/core';
import { CheckCoachQuestion } from '../../interfaces/interfaces';

@Component({
	selector: 'app-check-essay',
	templateUrl: './check-essay.component.html',
	styleUrls: ['./check-essay.component.scss']
})
export class CheckEssayComponent implements OnInit {
	@Input() testTopic: CheckCoachQuestion;

	textEssay = 'Test';
	themeEssay = 'My Hobby';
	fillingEssay = 512;

	ngOnInit(): void {}
}
