import { Component, Input, OnInit } from '@angular/core';

import { CheckCoachQuestion, CheckQuestion } from 'src/app/interfaces/interfaces';
import { checkQuestions } from '../../test-data/test-questions';

@Component({
	selector: 'app-check-grammar',
	templateUrl: './check-grammar.component.html',
	styleUrls: ['./check-grammar.component.scss']
})
export class CheckGrammarComponent implements OnInit {
	@Input() checkQuestions: CheckQuestion[];
	@Input() testGrammarAnswers: CheckCoachQuestion[];

	currentIndex = 0;
	testQuestions: CheckQuestion[] = [];

	ngOnInit(): void {
		this.testQuestions = checkQuestions;
	}
}
