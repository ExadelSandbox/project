import { Injectable } from '@angular/core';
import { serverAuthResponse, UserAuth } from '../interfaces/interfaces';
import { Router } from '@angular/router';
import { ApiService } from './api.service';
import { API_PATH } from '../constants/api.constants';

@Injectable({ providedIn: 'root' })
export class AuthService {
	readonly tokenLifetime: number = 3600 * 3 * 1000;

	constructor(private router: Router, private apiService: ApiService) {}

	get token(): string {
		const expDate = new Date(localStorage.getItem('access-token-exp') || '');
		if (new Date() > expDate) {
			this.logout();
			return '';
		}
		return localStorage.getItem('access-token') || '';
	}

	login(user: UserAuth): void {
		this.apiService
			.postRequest(API_PATH.AUTHENTICATE, user)
			.then((response) => {
				this.setToken(response);
				void this.router.navigate(['/main']);
			})
			.catch((err) => console.log(err));
	}

	logout() {
		localStorage.clear();
		void this.router.navigate(['/login']);
	}

	isAuthenticated(): boolean {
		// return !!this.token;
		return true;
	}

	private setToken(response: serverAuthResponse | null): void {
		if (response) {
			const expDate = new Date(new Date().getTime() + this.tokenLifetime);
			localStorage.setItem('access-token', response.token);
			localStorage.setItem('access-token-exp', expDate.toString());
		}
	}
}
