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
	selectedKey: number;
	selectDisabled = false;
	buttonDisabled = true;
	currentUser: any;
	createdTest: any;
	dateFormat = require('dateFormat');
	now = new Date();
	activeLevel: number;
	myAssignedLevel: number;

	constructor(
		public dialogRef: MatDialogRef<StartTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: MyAssigned,
		private apiService: ApiService,
		private submitTest: SubmitTestService,
		private router: Router,
		private user: UserService
	) {
		if (data) {
			this.selectedKey = Object.keys(EnglishLevels).indexOf(this.data.level);
			this.selected = Object.values(this.levelsValues)[this.selectedKey];
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
		this.activeLevel = Object.values(EnglishLevels).indexOf(event.value) + 1;
	}

	createTest() {
		this.myAssignedLevel = this.selectedKey + 1;

		const userBody = {
			id: 0,
			userId: this.currentUser.id,
			checkerId: null,
			assignTestId: this.data.id || null,
			levelType: this.activeLevel || this.myAssignedLevel,
			status: 1
		};

		this.createdTest = this.submitTest
			.createTest(userBody)
			.then(() => {
				void this.dialogRef.close();
				void this.router.navigate(['/test']);
			})
			.catch(() => {
				void this.dialogRef.close();
				void this.router.navigate(['/error']);
			});
	}
	closeModal() {
		this.dialogRef.close();
	}
}
