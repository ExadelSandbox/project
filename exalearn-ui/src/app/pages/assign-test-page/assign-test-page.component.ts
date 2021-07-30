import { Component, OnInit } from '@angular/core';
import { TableService } from '../../services/table.service';

@Component({
	selector: 'app-assign-test-page',
	templateUrl: './assign-test-page.component.html',
	styleUrls: ['./assign-test-page.component.scss']
})
export class AssignTestPageComponent {
	constructor(private tableService: TableService) {}

	isDataAvailable = false;
	data: object[] = [];
	ngOnInit(): void {
		this.tableService.getData('/api/users').then((data) => {
			this.data = data;
			this.isDataAvailable = true;
		});
	}
	tableColumns = ['fullName', 'assign test'];
	dataType = 'user';
}
