import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Question } from '../../interfaces/interfaces';

// import { questions } from '../../test-data/test-questions';

@Component({
	selector: 'app-question',
	templateUrl: './question.component.html',
	styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements OnInit, OnChanges {
	@Input() question: Question;
	testQuestions: Question[] = [];

	ngOnInit() {
		// this.testQuestions = questions;
	}

	mapOfGrammar = new Map();

	ngOnChanges(changes: SimpleChanges) {
		for (const propName in changes) {
			const chng = changes[propName];
			const previousTestData = chng.previousValue;
			const currentAnswer = {
				id: previousTestData.id,
				answer: previousTestData.userAnswer
			};
			this.mapOfGrammar.set(previousTestData.index, currentAnswer);
		}
	}
}
