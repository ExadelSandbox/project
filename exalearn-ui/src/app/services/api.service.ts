import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Router } from '@angular/router';

@Injectable({
	providedIn: 'root'
})
export class ApiService {
	headers = {
		'Content-Type': 'application/json',
		'Authorization': 'Bearer ' + (localStorage.getItem('access-token') || '')
	};
	constructor(private router: Router) {}

	async doRequest(path: string, options: any): Promise<any> {
		const response = await fetch(`${environment.API_URL}${path}`, options);
		if (response.ok) {
			return response.json();
		} else {
			if (response.status === 403 || response.status === 404) {
				void this.router.navigate(['/error']);
			}
			throw new Error(response.statusText);
		}
	}

	getRequest(path: string, params?: any): Promise<any> {
		return this.doRequest(this.parsePath(path, params), {
			method: 'GET',
			headers: this.headers
		});
	}

	postRequest(path: string, body: any, params?: any): Promise<any> {
		return this.doRequest(this.parsePath(path, params), {
			method: 'POST',
			headers: this.headers,
			body: JSON.stringify(body)
		});
	}

	putRequest(path: string, body: any, params?: any): Promise<any> {
		return this.doRequest(this.parsePath(path, params), {
			method: 'PUT',
			headers: this.headers,
			body: JSON.stringify(body)
		});
	}

	deleteRequest(path: string, body: any, params?: any): Promise<any> {
		return this.doRequest(this.parsePath(path, params), {
			method: 'DELETE',
			headers: this.headers,
			body: JSON.stringify(body)
		});
	}

	parsePath(path: string, params: any): string {
		let newPath: string = path;

		if (params && Object.keys(params).length !== 0) {
			const regex = /\{(.*?)\}/;
			const paramKeys = regex.exec(path);
			if (paramKeys) {
				const getKey = paramKeys[0];
				const getValue = params[paramKeys[1]];
				newPath = path.replace(getKey, getValue);
			}
		}

		return newPath;
	}
}
