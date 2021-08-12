import { Injectable } from '@angular/core';
import { API_PATH } from '../constants/api.constants';
import { ApiService } from './api.service';
import { User } from '../models/userModel';
import { EnglishLevels } from '../enums/enums';

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

	setUser(user: any): User | null {
		if (user) {
			if (user.levelType) {
				user.levelType = Object.values(EnglishLevels)[user.levelType - 1];
			}
			this.currentUser = new User(
				user.id,
				user.roleName,
				user.email,
				user.lastName,
				user.firstName,
				user.isActive,
				user.levelType
			);
			return this.currentUser;
		} else {
			return null;
		}
	}
}
