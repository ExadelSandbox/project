//TODO: add hrId to assign() when user service created
import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';
import { MatSelectChange } from '@angular/material/select';
import { MatCheckboxChange } from '@angular/material/checkbox';
import { EnglishLevels } from '../../enums/enums';
import { UserBack } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';

@Component({
	selector: 'app-assign-test-modal',
	templateUrl: './assign-test-modal.component.html',
	styleUrls: ['./assign-test-modal.component.scss']
})
export class AssignTestModalComponent {
	level: EnglishLevels | null = null;
	date: Date | null = null;
	sendEmail = true;
	minDate: Date;
	maxDate: Date;
	levels = EnglishLevels;
	DayInMilliseconds = 86400000;
	levelsValues = Object.values(this.levels);

	constructor(
		public dialogRef: MatDialogRef<AssignTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: UserBack,
		public apiService: ApiService
	) {
		const currentDate = new Date();
		this.minDate = new Date(currentDate.valueOf() + this.DayInMilliseconds);
	}

	assign(): void {
		if (this.level !== null && this.date !== null && this.data) {
			this.apiService.postRequest('/api/users/assignedTest', {
				'id': 0,
				'level': Object.values(this.levels).indexOf(this.level) + 1,
				'expireDate': this.date,
				'hrId': 0,
				'userId': this.data.id
			});
			this.dialogRef.close();
		}
	}

	onLevelChange(event: MatSelectChange): void {
		this.level = event.value;
	}

	onDateChange(event: MatDatepickerInputEvent<Date>): void {
		this.date = event.value;
	}

	toggle(event: MatCheckboxChange): void {
		this.sendEmail = event.checked;
	}
}
