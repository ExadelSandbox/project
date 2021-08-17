import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MyAssigned } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';
import { Router } from '@angular/router';
import { UserService } from '../../services/user.service';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-start-check-test',
	templateUrl: './start-check-test.component.html',
	styleUrls: ['./start-check-test.component.scss']
})
export class StartCheckTestComponent implements OnInit {
	selected = '';
	selectedKey: number;
	level: string | null;
	levels = EnglishLevels;
	levelsValues = Object.values(this.levels);

	constructor(
		public dialogRef: MatDialogRef<StartCheckTestComponent>,
		@Inject(MAT_DIALOG_DATA) public data: MyAssigned,
		private apiService: ApiService,
		private router: Router,
		private user: UserService
	) {
		if (data) {
			this.selectedKey = Object.keys(EnglishLevels).indexOf(this.data.level);
			this.selected = Object.values(this.levelsValues)[this.selectedKey];
		}
	}

	ngOnInit(): void {}
}
