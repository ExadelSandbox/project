import { Component, HostListener, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { TestService } from '../../services/test.service';

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

	@HostListener('window:visibilitychange', ['$event'])
	visibilityChangeHandler(event: any) {
		if (confirm('Are you sure?')) {
			event.returnValue = this.router.navigate(['/main']);
		} else {
			event.returnValue = true;
		}
	}

	public generatedQuestions: any;
	public grammarQuestions: any;
	public auditionQuestions: any;
	public essayTopic: string;
	public speakingTopic: string;
	public innerText = 'TIME LEFT';

	constructor(
		public translateService: TranslateService,
		private router: Router,
		public dialog: MatDialog,
		private testService: TestService
	) {}

	async ngOnInit() {
		this.generatedQuestions = await this.testService.getGeneratedTests();
		this.grammarQuestions = await this.testService.getGrammarQuestions();
		this.auditionQuestions = await this.testService.getAuditionQuestions();
		this.essayTopic = await this.testService.getEssayTopic();
		this.speakingTopic = await this.testService.getSpeakingTopic();
	}
}
