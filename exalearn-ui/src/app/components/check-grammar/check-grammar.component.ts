import { Component, Input, OnInit } from '@angular/core';

import { Question } from 'src/app/interfaces/interfaces';
import { questions } from '../../test-data/test-questions';

@Component({
	selector: 'app-check-grammar',
	templateUrl: './check-grammar.component.html',
	styleUrls: ['./check-grammar.component.scss']
})
export class CheckGrammarComponent implements OnInit {
	@Input() questions: Question[];
	currentIndex = 0;
	testQuestions: Question[] = [];

	ngOnInit(): void {
		this.testQuestions = questions;
	}
}
