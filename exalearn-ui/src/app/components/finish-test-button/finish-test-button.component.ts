import { Component } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { MatDialog } from '@angular/material/dialog';
import { FinishTestComponent } from '../finish-test/finish-test.component';

@Component({
	selector: 'app-finish-test-button',
	templateUrl: './finish-test-button.component.html',
	styleUrls: ['./finish-test-button.component.scss']
})
export class FinishTestButtonComponent {
	constructor(public submit: SubmitTestService, public dialog: MatDialog) {}

	public openDialog() {
		this.dialog.open(FinishTestComponent);
	}
}
