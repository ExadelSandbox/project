import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
	selector: 'app-report-message-modal',
	templateUrl: './report-message-modal.component.html',
	styleUrls: ['./report-message-modal.component.scss']
})
export class ReportMessageModalComponent {
	constructor(
		public dialogRef: MatDialogRef<ReportMessageModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: { modalHeader: string; comment: string }
	) {}
	closeModal(): void {
		this.dialogRef.close();
	}
}
