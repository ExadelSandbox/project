import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CheckCoachTest } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';
import { Router } from '@angular/router';

@Component({
	selector: 'app-start-check-test',
	templateUrl: './start-check-test.component.html',
	styleUrls: ['./start-check-test.component.scss']
})
export class StartCheckTestComponent {
	constructor(
		public dialogRef: MatDialogRef<StartCheckTestComponent>,
		@Inject(MAT_DIALOG_DATA) public data: CheckCoachTest,
		private apiService: ApiService,
		private router: Router
	) {}

	startCheckTest() {
		void this.dialogRef.close();
		void this.router.navigate(['/check-test-item']);
	}

	closeCheckTest() {
		this.dialogRef.close();
	}
}
