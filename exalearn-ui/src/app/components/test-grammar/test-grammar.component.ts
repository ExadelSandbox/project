import { Component, Input, OnInit } from '@angular/core';
import { Question } from 'src/app/interfaces/interfaces';
import { questions } from '../../test-data/test-questions';

@Component({
	selector: 'app-test-grammar',
	templateUrl: './test-grammar.component.html',
	styleUrls: ['./test-grammar.component.scss']
})
export class TestGrammarComponent implements OnInit {
	@Input() questions: Question[];
	currentIndex = 0;
	testQuestions: Question[] = [];

	ngOnInit() {
		this.testQuestions = questions;
	}
}
