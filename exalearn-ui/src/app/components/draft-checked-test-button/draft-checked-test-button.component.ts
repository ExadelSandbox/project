import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuditionService } from '../../services/audition.service';

@Component({
	selector: 'app-draft-checked-test-button',
	templateUrl: './draft-checked-test-button.component.html',
	styleUrls: ['./draft-checked-test-button.component.scss']
})
export class DraftCheckedTestButtonComponent implements OnInit {
	constructor(public router: Router, public auditionService: AuditionService) {}

	ngOnInit(): void {}

	public draft() {
		this.auditionService.submitTestPause();
		void this.router.navigate(['/main']);
	}
}
