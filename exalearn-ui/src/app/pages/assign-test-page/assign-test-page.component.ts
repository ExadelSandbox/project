import { Component, OnInit } from '@angular/core';
import { TableService } from '../../services/table.service';
import { UserBack } from '../../interfaces/interfaces';

@Component({
	selector: 'app-assign-test-page',
	templateUrl: './assign-test-page.component.html',
	styleUrls: ['./assign-test-page.component.scss']
})
export class AssignTestPageComponent implements OnInit {
	constructor(private tableService: TableService) {}

	isDataAvailable = false;
	data: UserBack[] = [];
	ngOnInit(): void {
		this.tableService.getData('/api/users').then((data: UserBack[]) => {
			data.forEach((element) => (element.fullName = element.firstName + ' ' + element.lastName));
			this.data = data;
			this.isDataAvailable = true;
		});
	}
	tableColumns = ['fullName', 'assign test'];
	dataType = 'user';
}
