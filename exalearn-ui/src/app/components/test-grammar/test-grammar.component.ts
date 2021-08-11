import { Component, Input, OnInit } from '@angular/core';
import { Question } from 'src/app/interfaces/interfaces';
import { Router } from '@angular/router';

@Component({
	selector: 'app-test-grammar',
	templateUrl: './test-grammar.component.html',
	styleUrls: ['./test-grammar.component.scss']
})
export class TestGrammarComponent implements OnInit {
	@Input() questionsGrammar: Question[];

	currentIndex = 0;
	testQuestions: Question[] = [];
	public isDataAvailable: boolean;

	constructor(private router: Router) {}

	ngOnInit() {
		if (this.questionsGrammar.length === 0) {
			this.isDataAvailable = false;
			void this.router.navigate(['/error']);
		} else {
			this.testQuestions = this.questionsGrammar;
			this.isDataAvailable = true;
		}
	}
}
