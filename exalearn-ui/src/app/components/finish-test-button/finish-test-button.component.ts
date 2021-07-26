import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
	selector: 'app-finish-test-button',
	templateUrl: './finish-test-button.component.html',
	styleUrls: ['./finish-test-button.component.scss']
})
export class FinishTestButtonComponent {
	constructor(private router: Router) {}

	public submitTest() {
		void this.router.navigate(['/main']);
	}
}
