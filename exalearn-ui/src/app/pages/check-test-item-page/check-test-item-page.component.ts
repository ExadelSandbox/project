import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-check-test-item-page',
	templateUrl: './check-test-item-page.component.html',
	styleUrls: ['./check-test-item-page.component.scss']
})
export class CheckTestItemPageComponent implements OnInit {
	passedTestId: number;
	dataCheckTest: any;

	constructor(private router: Router, private apiService: ApiService) {
		//this.passedTestId = this?.router?.getCurrentNavigation()?.extras?.state?.data.id;
		this.passedTestId = 1;
	}

	ngOnInit() {
		void this.apiService.getRequest(API_PATH.GET_CHECK_TEST, { passedTestId: this.passedTestId }).then((data) => {
			this.dataCheckTest = data;
			console.log(data);
		});
	}
}
