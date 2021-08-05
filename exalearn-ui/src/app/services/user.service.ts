import { Injectable } from '@angular/core';
import { API_PATH } from '../constants/api.constants';
import { ApiService } from './api.service';
import { User } from '../models/userModel';

@Injectable({
	providedIn: 'root'
})
export class UserService {
	currentUser: User | null;

	constructor(private apiService: ApiService) {}

	getUser(): Promise<boolean> {
		return this.apiService
			.getRequest(API_PATH.USER)
			.then((response) => {
				this.setUser(response);
				console.log('true');
				return true;
			})
			.catch(() => {
				console.log('false');
				return false;
			});
	}

	setUser(user: any): User | null {
		if (user) {
			console.log('set user', user); //TODO Del
			this.currentUser = new User(
				user.id,
				user.roleName,
				user.email,
				user.lastName,
				user.firstName,
				user.isActive
			);
			return this.currentUser;
		} else {
			return null;
		}
	}
}
