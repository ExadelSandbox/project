import { Component } from '@angular/core';
import { Location } from '@angular/common';

@Component({
	selector: 'app-assign-test-page',
	templateUrl: './assign-test-page.component.html',
	styleUrls: ['./assign-test-page.component.scss']
})
export class AssignTestPageComponent {
	constructor(private location: Location) {}
	tableColumns = ['user', 'assign test'];
	goBack(): void {
		this.location.back();
	}
}
