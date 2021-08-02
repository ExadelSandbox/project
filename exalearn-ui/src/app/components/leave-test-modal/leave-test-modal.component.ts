import { Component } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';

@Component({
	selector: 'app-leave-test-modal',
	templateUrl: './leave-test-modal.component.html',
	styleUrls: ['./leave-test-modal.component.scss']
})
export class LeaveTestModalComponent {
	constructor(
		public dialogRef: MatDialogRef<LeaveTestModalComponent>,
		private router: Router,
		public dialog: MatDialog
	) {}

	confirmLeave(): void {
		this.submitTest();
		this.dialogRef.close();
	}

	cancelLeave(): void {
		this.dialogRef.close();
	}

	public submitTest() {
		void this.router.navigate(['/main']);
	}
}
