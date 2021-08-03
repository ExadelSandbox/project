import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { API_PATH } from '../constants/api.constants';
import { Router } from '@angular/router';
import _ from 'lodash';

@Injectable({
	providedIn: 'root'
})
export default class SubmitTestService {
	constructor(private apiService: ApiService, private router: Router) {}

	public mapOfAnswers = new Map();

	getData() {
		return this.mapOfAnswers;
	}

	addData(indexOfAnswers: any, mapAnswers: any): void {
		this.mapOfAnswers.set(indexOfAnswers, mapAnswers);
	}

	submitData(): void {
		this.apiService
			.postRequest(API_PATH.POST_TEST, this.formatForRequest())
			.then(() => {
				console.log('sended');
			})
			.catch((err) => console.log(err));
	}

	debouncedSubmitData = _.debounce(this.submitData.bind(this), 3000, { maxWait: 15000 });

	formatForRequest() {
		return JSON.stringify(Array.from(this.mapOfAnswers.values()));
	}
}
