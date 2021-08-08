import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSelectChange } from '@angular/material/select';
import { EnglishLevels } from '../../enums/enums';
import { MyAssigned } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';
import SubmitTestService from '../../services/submit-test.service';
import { Router } from '@angular/router';
import { UserService } from '../../services/user.service';

@Component({
	selector: 'app-start-test-modal',
	templateUrl: './start-test-modal.component.html',
	styleUrls: ['./start-test-modal.component.scss']
})
export class StartTestModalComponent implements OnInit {
	level: string | null;
	levels = EnglishLevels;
	levelsValues = Object.values(this.levels);
	selected = '';
	selectDisabled = false;
	buttonDisabled = true;
	currentUser: any;
	passedTest: any;
	dateFormat = require('dateFormat');
	now = new Date();
	activeLevel: any;

	constructor(
		public dialogRef: MatDialogRef<StartTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: MyAssigned,
		private apiService: ApiService,
		private submitTest: SubmitTestService,
		private router: Router,
		private user: UserService
	) {
		if (data) {
			// @ts-ignore
			this.selected = this.levelsValues[this.data.level];
			this.selectDisabled = true;
			this.buttonDisabled = false;
		}
	}

	ngOnInit() {
		this.currentUser = this.user.currentUser;
	}

	onLevelChange(event: MatSelectChange): void {
		this.level = event.value;
		this.buttonDisabled = false;
		// @ts-ignore
		this.activeLevel = this.levelsValues.indexOf(this.level) + 1;
	}

	createPassedTest() {
		const userBody = {
			id: 0,
			userId: this.currentUser.id,
			checkerId: null,
			assignTestId: this.data.id || null,
			levelType: this.activeLevel || this.data.level,
			status: 1
		};

		this.passedTest = this.submitTest.createTest(userBody).then(() => {
			void this.dialogRef.close();
			void this.router.navigate(['/test']);
		});
	}
}
