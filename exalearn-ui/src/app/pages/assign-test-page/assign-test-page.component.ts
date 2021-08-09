import { Component, OnInit } from '@angular/core';
import { UserBack } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-assign-test-page',
	templateUrl: './assign-test-page.component.html',
	styleUrls: ['./assign-test-page.component.scss']
})
export class AssignTestPageComponent implements OnInit {
	constructor(private apiService: ApiService) {}

	isDataAvailable = false;
	data: UserBack[] = [];
	ngOnInit(): void {
		this.apiService.getRequest(API_PATH.USERS).then((data: UserBack[]) => {
			data.forEach((element) => (element.fullName = element.firstName + ' ' + element.lastName));
			this.data = data;
			this.isDataAvailable = true;
		});
	}
	tableColumns = ['fullName', 'assign test'];
	dataType = 'user';
}
