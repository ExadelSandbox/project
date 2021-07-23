import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class AuthService {
	private isAuth = false;

	login() {
		this.isAuth = true;
	}

	//TODO CHANGED 1500 to 15
	isAuthenticated(): Promise<boolean> {
		return new Promise((resolve) => {
			setTimeout(() => {
				resolve(this.isAuth);
			}, 15);
		});
	}
}
