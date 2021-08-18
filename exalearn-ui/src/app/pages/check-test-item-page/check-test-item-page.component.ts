import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
	selector: 'app-check-test-item-page',
	templateUrl: './check-test-item-page.component.html',
	styleUrls: ['./check-test-item-page.component.scss']
})
export class CheckTestItemPageComponent implements OnInit {
	passedTestId: number;

	constructor(private router: Router) {
		this.passedTestId = this?.router?.getCurrentNavigation()?.extras?.state?.data.id;
	}

	ngOnInit(): void {}
}
