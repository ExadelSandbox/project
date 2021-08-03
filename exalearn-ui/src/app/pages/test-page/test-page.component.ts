import { Component, HostListener, OnInit } from '@angular/core';
import { questions, questionsAudio } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import SubmitTestService from '../../services/submit-test.service';

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

	public testQuestions: Question[] = [];
	public testQuestionsAudio: Question[] = [];
	public innerText = 'TIME LEFT';

	constructor(
		public translateService: TranslateService,
		private router: Router,
		public dialog: MatDialog,
		private submit: SubmitTestService
	) {}

	ngOnInit() {
		this.testQuestions = questions;
		this.testQuestionsAudio = questionsAudio;
	}
}
