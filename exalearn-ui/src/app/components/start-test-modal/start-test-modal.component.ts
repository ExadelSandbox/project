import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSelectChange } from '@angular/material/select';
import { EnglishLevels } from '../../enums/enums';
import { Assignment } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';
import SubmitTestService from '../../services/submit-test.service';

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
	//TODO TESTING BACKEND
	currentUser: any;
	assignedTests: any;
	createPassed: any;
	dateFormat = require('dateFormat');
	now = new Date();

	constructor(
		public dialogRef: MatDialogRef<StartTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: Assignment,
		private apiService: ApiService,
		private submitTest: SubmitTestService
	) {
		if (data) {
			this.selected = data.level;
			this.selectDisabled = true;
			this.buttonDisabled = false;
		}
	}

	async ngOnInit() {
		this.currentUser = await this.apiService.getRequest('/api/users/user');
		this.assignedTests = await this.apiService.getRequest(`/api/users/${this.currentUser.id}/userAssignedTest`);
	}

	onLevelChange(event: MatSelectChange): void {
		this.level = event.value;
		this.buttonDisabled = false;
	}

	async createPassedTest() {
		const userBody = {
			id: 0,
			userId: this.currentUser.id,
			checkerId: this.assignedTests.checkerId,
			assignTestId: this.assignedTests.assignTestId,
			levelType: this.data.level || this.assignedTests.levelType,
			assessment: 0,
			status: 1,
			passedTestDate: this.dateFormat(this.now, 'isoUtcDateTime')
		};
		this.createPassed = await this.apiService
			.postRequest('/api/questions/createPassedTest', userBody)
			.then((response) => {
				this.submitTest.setTestPassedId(response.id);
			});
	}

	// async createPassedTest() {
	// 	const userBody = {
	// 		id: 0,
	// 		userId: this.currentUser.id,
	// 		checkerId: this.assignedTests.checkerId,
	// 		assignTestId: this.assignedTests.assignTestId,
	// 		levelType: this.data.level || this.assignedTests.levelType,
	// 		assessment: 0,
	// 		status: 1,
	// 		passedTestDate: this.dateFormat(this.now, 'isoUtcDateTime')
	// 	};
	// 	this.createPassed = await this.apiService.postRequest('/api/questions/createPassedTest', userBody);
	// 	this.submitTest.setTestPassedId(this.createPassed);
	// }
}
