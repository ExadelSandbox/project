import { Component, HostListener, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
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

	@HostListener('window:visibilitychange', ['$event'])
	visibilityChangeHandler(event: any) {
		if (confirm('Are you sure?')) {
			event.returnValue = this.router.navigate(['/main']);
		} else {
			event.returnValue = true;
		}
	}

	public generatedQuestions: any;
	public innerText = 'TIME LEFT';

	constructor(
		public translateService: TranslateService,
		private router: Router,
		public dialog: MatDialog,
		private apiService: ApiService
	) {}

	async ngOnInit() {
		//TODO: values of levelType must be dynamic
		this.generatedQuestions = await this.apiService.getRequest(API_PATH.USERS).then((response) => response);
		console.log(this.generatedQuestions);
	}
}
