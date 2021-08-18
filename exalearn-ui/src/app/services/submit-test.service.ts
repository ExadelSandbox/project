import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { API_PATH } from '../constants/api.constants';
import { Router } from '@angular/router';
import { Test } from '../interfaces/interfaces';

@Injectable({
	providedIn: 'root'
})
export default class SubmitTestService {
	constructor(private apiService: ApiService, private router: Router) {}

	public mapOfAnswers = new Map();
	public test: Test;

	getData() {
		return this.mapOfAnswers;
	}

	addData(indexOfAnswers: any, mapAnswers: any): void {
		this.mapOfAnswers.set(indexOfAnswers, mapAnswers);
	}

	submitData(): void {
		console.log(Array.from(this.mapOfAnswers.values()));
		this.apiService.postRequest(API_PATH.POST_TEST, this.formatForRequest()).catch((err) => console.log(err));
	}

	formatForRequest() {
		return Array.from(this.mapOfAnswers.values());
	}

	getTest(): any {
		return this.test;
	}

	setTest(value: any) {
		this.test = value;
	}

	createTest(userBody: any) {
		return this.apiService.postRequest('/api/questions/generateTest', userBody).then((response) => {
			this.setTest(response);
		});
	}

	clearMap(): void {
		this.mapOfAnswers.clear();
	}
}
