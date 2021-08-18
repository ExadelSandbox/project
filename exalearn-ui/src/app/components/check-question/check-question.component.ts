import { Component, Input, OnInit } from '@angular/core';
import { CheckCoachQuestion, CheckQuestion } from '../../interfaces/interfaces';
import { checkQuestions } from '../../test-data/test-questions';

@Component({
	selector: 'app-check-question',
	templateUrl: './check-question.component.html',
	styleUrls: ['./check-question.component.scss']
})
export class CheckQuestionComponent implements OnInit {
	@Input() answer: CheckCoachQuestion;
	@Input() currentIndex: number;

	// testQuestions: CheckQuestion[] = [];

	ngOnInit() {}
}
