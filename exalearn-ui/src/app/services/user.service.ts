import { Injectable } from '@angular/core';
import { API_PATH } from '../constants/api.constants';
import { ApiService } from './api.service';

@Injectable({
	providedIn: 'root'
})
export class UserService {
	userInterface: object;

	constructor(private apiService: ApiService) {}

	setUser(response: object): void {
		this.userInterface = response;
		console.log(this.userInterface);
	}

	refreshUser(response: object): void {
		this.apiService
			.getRequest(API_PATH.USERS)
			.then((response) => {
				this.userInterface = response;
			})
			.catch((err) => console.log(err));
	}
}
