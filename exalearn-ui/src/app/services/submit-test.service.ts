import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { API_PATH } from '../constants/api.constants';
import { Router } from '@angular/router';

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
		console.log(JSON.stringify(Array.from(this.mapOfAnswers.values())));
		this.apiService.postRequest(API_PATH.POST_TEST, this.formatForRequest()).catch((err) => console.log(err));
	}

	formatForRequest() {
		return JSON.stringify(Array.from(this.mapOfAnswers.values()));
	}
}
