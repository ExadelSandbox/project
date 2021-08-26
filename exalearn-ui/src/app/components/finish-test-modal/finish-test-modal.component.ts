import { Component } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';

@Component({
	selector: 'app-finish-test-modal',
	templateUrl: './finish-test-modal.component.html',
	styleUrls: ['./finish-test-modal.component.scss']
})
export class FinishTestModalComponent {
	constructor(public dialogRef: MatDialogRef<FinishTestModalComponent>, public dialog: MatDialog) {}

	confirmClose(): void {
		this.dialogRef.close();
	}
}
