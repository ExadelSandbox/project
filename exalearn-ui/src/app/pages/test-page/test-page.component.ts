import { Component, OnInit } from '@angular/core';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';
import { environment } from '../../../environments/environment';
import { TranslateService } from '@ngx-translate/core';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	testQuestions: Question[] = [];

	constructor(public translateService: TranslateService) {}

	ngOnInit() {
		this.testQuestions = questions;
		//TODO use user state from backend. For the test, because then we will accept the user's language from the backend.
		//TODO When the page is reloaded, the state is cleared and we have no language
		// this.translateService.use(environment.defaultLocale);
	}
}
