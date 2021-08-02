import { Injectable } from '@angular/core';
import { API_PATH } from '../constants/api.constants';
import { ApiService } from './api.service';

@Injectable({
	providedIn: 'root'
})
export class UserService {
	userInterface: object;
	userRole: string;

	constructor(private apiService: ApiService) {}

	getUser(): void {
		this.apiService
			.getRequest(API_PATH.USER)
			.then((response) => {
				this.setUser(response);
			})
			.catch((err) => console.log(err));
	}

	setUser(response: object): void {
		this.userInterface = response;
		this.userRole = Object.values(response)[1].toLowerCase();
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
