import { Component, Input, OnInit } from '@angular/core';
import { Question } from 'src/app/interfaces/interfaces';

@Component({
	selector: 'app-test-grammar',
	templateUrl: './test-grammar.component.html',
	styleUrls: ['./test-grammar.component.scss']
})
export class TestGrammarComponent implements OnInit {
	@Input() questionsGrammar: Question[];
	@Input() passedTest: any;

	currentIndex = 0;
	testQuestions: Question[] = [];
	public passTestId: number;

	ngOnInit() {
		this.testQuestions = this.questionsGrammar;
		this.passTestId = this.passedTest.id;
	}
}
