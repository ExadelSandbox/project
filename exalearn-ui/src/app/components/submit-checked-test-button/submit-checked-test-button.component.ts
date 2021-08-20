import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { AuditionService } from '../../services/audition.service';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-submit-checked-test-button',
	templateUrl: './submit-checked-test-button.component.html',
	styleUrls: ['./submit-checked-test-button.component.scss']
})
export class SubmitCheckedTestButtonComponent implements OnInit {
	@Input() passedTestId: number | undefined;
	@Input() essayMark: number | undefined;
	@Input() speakingMark: number | undefined;

	constructor(
		public dialog: MatDialog,
		public router: Router,
		public translateService: TranslateService,
		public auditionService: AuditionService,
		private apiService: ApiService
	) {}

	ngOnInit(): void {}

	public async submitTest() {
		const bodyAssessment = {
			'passedTestId': this.passedTestId,
			'essay': this.essayMark,
			'speaking': this.speakingMark
		};

		this.auditionService.submitTestPause();
		void (await this.apiService.postRequest(API_PATH.TEST_ASSESSMENT, bodyAssessment));
		void (await this.router.navigate(['/main']));
	}
}
