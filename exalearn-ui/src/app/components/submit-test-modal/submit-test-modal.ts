import { Component, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { FinishTestModalComponent } from '../finish-test-modal/finish-test-modal.component';
import { TranslateService } from '@ngx-translate/core';
import { AuditionService } from '../../services/audition.service';

@Component({
	selector: 'app-finish-test',
	templateUrl: './submit-test-modal.component.html',
	styleUrls: ['./submit-test-modal.scss']
})
export class SubmitTestModalComponent {
	constructor(
		public submit: SubmitTestService,
		public dialog: MatDialog,
		public router: Router,
		public dialogRef: MatDialogRef<FinishTestModalComponent>,
		public translateService: TranslateService,
		public auditionService: AuditionService
	) {}

	public async submitTest() {
		this.auditionService.submitTestPause();
		this.submit.submitData();
		this.dialogRef.close();
		void (await this.router.navigate(['/main']));
		this.dialog.open(FinishTestModalComponent);
		this.submit.clearMap();
	}

	public closeDialog() {
		this.dialogRef.close();
	}
}
