import { Component, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { FinishTestModalComponent } from '../finish-test-modal/finish-test-modal.component';
import { TranslateService } from '@ngx-translate/core';

@Component({
	selector: 'app-finish-test',
	templateUrl: './finish-test.component.html',
	styleUrls: ['./finish-test.component.scss']
})
export class FinishTestComponent {
	constructor(
		public submit: SubmitTestService,
		public dialog: MatDialog,
		public router: Router,
		public dialogRef: MatDialogRef<FinishTestModalComponent>,
		public translateService: TranslateService
	) {}

	public async submitTest() {
		this.submit.submitData();
		void (await this.router.navigate(['/main']));
		this.dialog.open(FinishTestModalComponent);
	}

	public closeDialog() {
		this.dialogRef.close();
	}
}
