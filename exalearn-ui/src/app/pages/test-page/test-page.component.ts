import { Component, OnInit } from '@angular/core';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	testQuestions: Question[] = [];
	innerText = 'TIME LEFT';

	constructor(public translateService: TranslateService) {}

	ngOnInit() {
		this.testQuestions = questions;
	}
}
