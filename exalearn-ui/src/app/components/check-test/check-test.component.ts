import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSelectChange } from '@angular/material/select';
import { EnglishLevels } from '../../enums/enums';
import { Assignment } from '../../interfaces/interfaces';

@Component({
	selector: 'app-check-test',
	templateUrl: './check-test.component.html',
	styleUrls: ['./check-test.component.scss']
})
export class CheckTestComponent {
	level: string | null;
	levels = EnglishLevels;
}
