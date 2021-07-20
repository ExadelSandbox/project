import { Component, OnInit } from '@angular/core';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	testQuestions: Question[] = [];

	constructor() {}

	ngOnInit() {
		this.testQuestions = questions;
	}
}
