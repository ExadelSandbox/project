import { Component, Input, OnInit } from '@angular/core';
import { CheckCoach, CheckCoachQuestion } from '../../interfaces/interfaces';

@Component({
	selector: 'app-check-essay',
	templateUrl: './check-essay.component.html',
	styleUrls: ['./check-essay.component.scss']
})
export class CheckEssayComponent implements OnInit {
	@Input() testTopicAnswers: CheckCoachQuestion;

	textEssay = 'Test';
	themeEssay = 'My Hobby';
	fillingEssay = 512;

	ngOnInit(): void {}
}
