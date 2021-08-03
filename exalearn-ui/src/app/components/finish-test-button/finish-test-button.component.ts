import { Component } from '@angular/core';
import { Router } from '@angular/router';
import SubmitTestService from '../../services/submit-test.service';

@Component({
	selector: 'app-finish-test-button',
	templateUrl: './finish-test-button.component.html',
	styleUrls: ['./finish-test-button.component.scss']
})
export class FinishTestButtonComponent {
	constructor(private router: Router, public submit: SubmitTestService) {}

	public async submitTest() {
		this.submit.submitData();
		void (await this.router.navigate(['/main']));
	}
}
