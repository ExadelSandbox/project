import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Answer, Question } from '../../interfaces/interfaces';
import { questions } from '../../test-data/test-questions';

@Component({
	selector: 'app-question',
	templateUrl: './question.component.html',
	styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements OnInit, OnChanges {
	@Input() question: Question;
	testQuestions: Question[] = [];

	testAnswer: Answer[] = [];

	ngOnInit() {
		this.testQuestions = questions;
	}

	ngOnChanges(changes: SimpleChanges) {
		for (const propName in changes) {
			const chng = changes[propName];
			const currentTestData = chng.currentValue;
			const previousTestData = chng.previousValue;

			console.log(`${currentTestData?.id} + ${currentTestData?.userAnswer}`);
			console.log(`${previousTestData?.id} + ${previousTestData?.userAnswer}`);
		}
	}
}
