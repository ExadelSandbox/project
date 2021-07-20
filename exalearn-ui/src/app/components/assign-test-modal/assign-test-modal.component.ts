import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';
import { MatSelectChange } from '@angular/material/select';
import { MatCheckboxChange } from '@angular/material/checkbox';
import { EnglishLevels } from '../../Enums/enums';

@Component({
	selector: 'app-assign-test-modal',
	templateUrl: './assign-test-modal.component.html',
	styleUrls: ['./assign-test-modal.component.scss']
})
export class AssignTestModalComponent {
	level: string | null;
	date: Date | null;
	sendEmail = true;
	minDate: Date;
	maxDate: Date;
	levels = EnglishLevels;
	DayInMilliseconds = 86400000;
	levelsValues = Object.values(this.levels);
	constructor(
		public dialogRef: MatDialogRef<AssignTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: { name: string }
	) {
		const currentDate = new Date();
		this.minDate = new Date(currentDate.valueOf() + this.DayInMilliseconds);
	}
	assign(): void {
		this.dialogRef.close();
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
