import { Component, ElementRef, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import SubmitTestService from '../../services/submit-test.service';
import { MatDialog } from '@angular/material/dialog';
import { FinishTestModalComponent } from '../finish-test-modal/finish-test-modal.component';

@Component({
	selector: 'app-finish-test-button',
	templateUrl: './finish-test-button.component.html',
	styleUrls: ['./finish-test-button.component.scss']
})
export class FinishTestButtonComponent {
	constructor(private router: Router, public submit: SubmitTestService, public dialog: MatDialog) {}

	public async submitTest() {
		this.submit.submitData();
		void (await this.router.navigate(['/main']));
		this.dialog.open(FinishTestModalComponent);
	}
}
