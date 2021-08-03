import { Component, HostListener, OnInit } from '@angular/core';
import { questions, questionsAudio } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import SubmitTestService from '../../services/submit-test.service';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	@HostListener('window:beforeunload', ['$event'])
	beforeUnloadHandler(event: any) {
		return false;
	}

	@HostListener('window:unload', ['$event'])
	unloadHandler(event: any) {
		this.submit.submitData();
	}

	@HostListener('window:visibilitychange', ['$event'])
	visibilityChangeHandler(event: any) {
		if (confirm('Are you sure?')) {
			this.submit.submitData();
			event.returnValue = this.router.navigate(['/main']);
		} else {
			event.returnValue = true;
		}
	}

	public generatedQuestions: any;
	public testQuestions: Question[] = [];
	public testQuestionsAudio: Question[] = [];
	public innerText = 'TIME LEFT';

	constructor(
		public translateService: TranslateService,
		private router: Router,
		public dialog: MatDialog,
		private apiService: ApiService,
		private submit: SubmitTestService
	) {}

	// async ngOnInit() {
	// 	this.generatedQuestions = await this.apiService.getRequest(API_PATH.TEST).then((response) => response);
	// 	this.testQuestions = questions;
	// 	this.testQuestionsAudio = questionsAudio;
	// }
	ngOnInit() {
		this.testQuestions = questions;
		this.testQuestionsAudio = questionsAudio;
	}
}
