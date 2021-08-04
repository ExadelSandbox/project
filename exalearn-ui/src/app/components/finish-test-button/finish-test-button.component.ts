import { Component, ElementRef, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import SubmitTestService from '../../services/submit-test.service';
import { MatDialog } from '@angular/material/dialog';
import { FinishTestModalComponent } from '../finish-test-modal/finish-test-modal.component';
import { TimerService } from '../../services/timer.service';
import { TimerComponent } from '../timer/timer.component';

@Component({
	selector: 'app-finish-test-button',
	templateUrl: './finish-test-button.component.html',
	styleUrls: ['./finish-test-button.component.scss']
})
export class FinishTestButtonComponent {
	@ViewChild(TimerComponent)
	timerContainer: TimerComponent;

	constructor(
		private router: Router,
		public submit: SubmitTestService,
		public dialog: MatDialog,
		public timer: TimerService
	) {}

	public async submitTest() {
		this.submit.submitData();
		this.timerContainer.clearIntervalDurationTimer();
		void (await this.router.navigate(['/main']));
		this.dialog.open(FinishTestModalComponent);
	}
}
