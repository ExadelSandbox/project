import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { Question } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import SubmitTestService from '../../services/submit-test.service';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';
import { StartTestModalComponent } from '../../components/start-test-modal/start-test-modal.component';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	public testQuestions: Question[] = [];
	public testQuestionsAudio: Question[] = [];
	public textEssay: string;
	public textSpeaking: string;
	public innerText = 'TIME LEFT';
	public isDataAvailable = false;

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

	constructor(
		public translateService: TranslateService,
		private router: Router,
		public dialog: MatDialog,
		private apiService: ApiService,
		private submit: SubmitTestService
	) {}

	ngOnInit() {
		void this.apiService.getRequest(API_PATH.TEST).then((response) => {
			this.testQuestions = response.grammarQuestion;
			this.testQuestionsAudio = response.auditionQuestion;
			this.textEssay = response.essayTopic;
			this.textSpeaking = response.speakingTopic;
			this.isDataAvailable = true;
			//TODO Delete
			// console.log(this.testQuestions);
			// console.log(this.testQuestionsAudio);
			// console.log(this.textEssay);
			// console.log(this.textSpeaking);
		});
	}
}
