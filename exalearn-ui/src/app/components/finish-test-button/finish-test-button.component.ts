import { Component } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { MatDialog } from '@angular/material/dialog';
import { SubmitTestModalComponent } from '../submit-test-modal/submit-test-modal';

@Component({
	selector: 'app-finish-test-button',
	templateUrl: './finish-test-button.component.html',
	styleUrls: ['./finish-test-button.component.scss']
})
export class FinishTestButtonComponent {
	constructor(public submit: SubmitTestService, public dialog: MatDialog) {}

	public openDialog() {
		this.dialog.open(SubmitTestModalComponent);
	}
}
