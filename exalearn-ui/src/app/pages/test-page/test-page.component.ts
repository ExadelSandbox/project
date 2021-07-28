import { Component, OnDestroy, OnInit } from '@angular/core';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';
import { ComponentCanDeactivate } from '../../guards/leave.guard';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { LeaveTestModalComponent } from '../../components/leave-test-modal/leave-test-modal.component';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit, OnDestroy {
	testQuestions: Question[] = [];
	saved = false;

	save() {
		this.saved = true;
	}

	constructor(public translateService: TranslateService, private router: Router, public dialog: MatDialog) {}

	eventListeners = false;

	ngOnInit() {
		this.testQuestions = questions;
		if (!this.eventListeners) {
			this.eventListeners = true;
			window.addEventListener('beforeunload', this.closeRefreshPage.bind(this));
			window.addEventListener('blur', this.switchBetweenTabs.bind(this));
		}
	}

	ngOnDestroy() {
		this.eventListeners = false;
		window.removeEventListener('beforeunload', this.closeRefreshPage.bind(this));
		window.removeEventListener('blur', this.switchBetweenTabs.bind(this));
	}

	closeRefreshPage(e: any) {
		if (this.eventListeners) {
			e.preventDefault();
			e.stopPropagation();
		}
	}

	switchBetweenTabs(e: any) {
		if (this.eventListeners) {
			e.returnValue = this.dialog.open(LeaveTestModalComponent, {
				width: '50%'
			});
		}
	}

	canDeactivate(): boolean | Observable<boolean> {
		if (!this.saved) {
			return confirm('Вы хотите покинуть страницу? Все несохраненные данные будут утеряны.');
		} else {
			return true;
		}
	}
}
