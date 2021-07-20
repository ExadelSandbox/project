import { Component, Input, OnInit } from '@angular/core';
import { Question } from '../../interfaces/interfaces';
import { questions } from '../../test-data/test-questions';

@Component({
	selector: 'app-question',
	templateUrl: './question.component.html',
	styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements OnInit {
	@Input() question: Question;
	testQuestions: Question[] = [];

	ngOnInit() {
		this.testQuestions = questions;
	}
}
