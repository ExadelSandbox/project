import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { PassedTest } from '../../interfaces/interfaces';

@Component({
	selector: 'app-view-test-modal',
	templateUrl: './view-test-modal.component.html',
	styleUrls: ['./view-test-modal.component.scss']
})
export class ViewTestModalComponent {
	constructor(
		public dialogRef: MatDialogRef<ViewTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: PassedTest
	) {}

	closeModal() {
		this.dialogRef.close();
	}
}
