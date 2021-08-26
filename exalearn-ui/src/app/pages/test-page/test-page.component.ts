import { Component, HostListener, OnInit } from '@angular/core';
import { Question, Test, testAnswer, topicQuestion } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import SubmitTestService from '../../services/submit-test.service';
import { ApiService } from '../../services/api.service';

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
	public isDataAvailable: boolean;

	@HostListener('window:beforeunload', ['$event'])
	beforeUnloadHandler(event: any) {
		this.submit.submitData();
		return false;
	}

	@HostListener('window:unload', ['$event'])
	unloadHandler(event: any) {
		void this.router.navigate(['/main']);
	}

	@HostListener('document:blur', ['$event'])
	blurChangeHandler(event: any) {
		if (confirm("If you really want to test your English level, don't switch between browser tabs")) {
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
		const test: Test = this.submit.getTest();
		this.isDataAvailable = false;
		if (!test) {
			void this.router.navigate(['/main']);
		} else {
			this.testPassedId = test.passedTestId;
			this.testQuestions = test.grammarQuestion;
			this.testQuestionsAudio = test.auditionQuestion;
			this.textTopic = test.topicQuestion;
			this.isDataAvailable = true;
			this.addNullData();
		}
	}
	addNullData(): void {
		this.testQuestions.forEach((el: Question) => {
			const currentAnswer: testAnswer = {
				id: 0,
				passedTestId: this.testPassedId,
				questionId: el.id,
				reportedMessage: null,
				userAnswer: null,
				assessment: 0
			};
			this.submit.addData(el.id, currentAnswer);
		});
		this.testQuestionsAudio.forEach((el: Question) => {
			const currentAnswer: testAnswer = {
				id: 0,
				passedTestId: this.testPassedId,
				questionId: el.id,
				reportedMessage: null,
				userAnswer: null,
				assessment: 0
			};
			this.submit.addData(el.id, currentAnswer);
		});
		const essayAnswer: testAnswer = {
			id: 0,
			passedTestId: this.testPassedId,
			questionId: this.textTopic[0].id,
			reportedMessage: null,
			userAnswer: null,
			assessment: 0
		};
		this.submit.addData('essay', essayAnswer);
		const speakingAnswer: testAnswer = {
			id: 0,
			passedTestId: this.testPassedId,
			questionId: this.textTopic[1].id,
			reportedMessage: null,
			userAnswer: null,
			assessment: 0
		};
		this.submit.addData('speaking', speakingAnswer);
	}
}
