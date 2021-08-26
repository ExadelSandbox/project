import { Component } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import SubmitTestService from '../../services/submit-test.service';

@Component({
	selector: 'app-leave-test-modal',
	templateUrl: './leave-test-modal.component.html',
	styleUrls: ['./leave-test-modal.component.scss']
})
export class LeaveTestModalComponent {
	constructor(
		public dialogRef: MatDialogRef<LeaveTestModalComponent>,
		private router: Router,
		public dialog: MatDialog,
		public submit: SubmitTestService
	) {}

	confirmLeave(): void {
		this.submitTest();
		this.dialogRef.close();
	}

	public submitTest() {
		void this.submit.submitData();
		void this.router.navigate(['/main']);
	}
}
