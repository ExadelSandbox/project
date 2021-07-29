import { Component, HostListener, OnInit } from '@angular/core';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	@HostListener('window:beforeunload', ['$event'])
	beforeUnloadHandler(event: any) {
		event.preventDefault();
		event.returnValue = '';
	}

	@HostListener('window:visibilitychange', ['$event'])
	visibilityChangeHandler(event: any) {
		if (confirm('Are you sure?')) {
			event.returnValue = this.router.navigate(['/main']);
		} else {
			event.returnValue = true;
		}
	}

	testQuestions: Question[] = [];

	constructor(public translateService: TranslateService, private router: Router, public dialog: MatDialog) {}

	ngOnInit() {
		this.testQuestions = questions;
	}
}
