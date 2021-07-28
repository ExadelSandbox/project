import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSelectChange } from '@angular/material/select';
import { EnglishLevels } from '../../enums/enums';
import { Assignment } from '../../interfaces/interfaces';

@Component({
	selector: 'app-start-test-modal',
	templateUrl: './start-test-modal.component.html',
	styleUrls: ['./start-test-modal.component.scss']
})
export class StartTestModalComponent {
	level: string | null;
	levels = EnglishLevels;
	levelsValues = Object.values(this.levels);
	selected = '';
	selectDisabled = false;
	buttonDisabled = true;

	constructor(
		public dialogRef: MatDialogRef<StartTestModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: Assignment
	) {
		if (data) {
			this.selected = data.level;
			this.selectDisabled = true;
			this.buttonDisabled = false;
		}
	}

	onLevelChange(event: MatSelectChange): void {
		this.level = event.value;
		this.buttonDisabled = false;
	}
}
