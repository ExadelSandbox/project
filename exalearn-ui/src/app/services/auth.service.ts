import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class AuthService {
	private isAuth = true;

	login() {
		this.isAuth = true;
	}

	isAuthenticated(): Promise<boolean> {
		return new Promise((resolve) => {
			setTimeout(() => {
				resolve(this.isAuth);
			}, 1500);
		});
	}
}
