import { Injectable } from '@angular/core';
import { API_PATH } from '../constants/api.constants';
import { ApiService } from './api.service';
import { User } from '../models/userModel';
import { UserBack } from '../interfaces/interfaces';

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
				return true;
			})
			.catch(() => {
				return false;
			});
	}

	setUser(user: UserBack): User | null {
		if (user) {
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
