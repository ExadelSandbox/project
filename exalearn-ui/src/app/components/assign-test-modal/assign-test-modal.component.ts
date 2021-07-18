import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';
import { MatSelectChange } from '@angular/material/select';

@Component({
	selector: 'app-assign-test-modal',
	templateUrl: './assign-test-modal.component.html',
	styleUrls: ['./assign-test-modal.component.scss']
})
export class AssignTestModalComponent implements OnInit {
	constructor(
		public dialogRef: MatDialogRef<AssignTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: { name: string }
	) {}
	assign() {
		this.dialogRef.close();
	}
	onLevelChange(event: MatSelectChange) {
		console.log(event.value);
	}
	onDateChange(event: MatDatepickerInputEvent<unknown>) {
		console.log(event.value);
	}
	foods: Food[] = [
		{ value: 'A1', viewValue: 'A1' },
		{ value: 'A2', viewValue: 'A2' },
		{ value: 'B1', viewValue: 'B1' }
	];
	ngOnInit(): void {}
}
interface Food {
	value: string;
	viewValue: string;
}
