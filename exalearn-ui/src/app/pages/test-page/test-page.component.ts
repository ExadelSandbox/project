import { Component, HostListener, OnInit } from '@angular/core';
import { Question, Test, testAnswer, topicQuestion } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import SubmitTestService from '../../services/submit-test.service';
import { ApiService } from '../../services/api.service';
import { StartTestModalComponent } from '../../components/start-test-modal/start-test-modal.component';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	public testQuestions: Question[] = [];
	public testQuestionsAudio: Question[] = [];
	public textTopic: topicQuestion[] = [];
	public testPassedId: number;
	public innerText = 'TIME LEFT';
	public isDataAvailable = false;
	public startModal: any = StartTestModalComponent;
	public test: Test = this.submit.getTest();

	@HostListener('window:beforeunload', ['$event'])
	beforeUnloadHandler(event: any) {
		this.submit.submitData();
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

	constructor(
		public translateService: TranslateService,
		private router: Router,
		public dialog: MatDialog,
		private apiService: ApiService,
		private submit: SubmitTestService
	) {}

	ngOnInit() {
		if (this.test === undefined) {
			void this.router.navigate(['/main']);
		} else {
			this.testPassedId = this.test.passedTestId;
			this.testQuestions = this.test.grammarQuestion;
			this.testQuestionsAudio = this.test.auditionQuestion;
			this.textTopic = this.test.topicQuestion;
			this.isDataAvailable = true;
		}
	}
}
