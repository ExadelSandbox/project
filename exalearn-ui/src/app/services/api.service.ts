import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

@Injectable({
	providedIn: 'root'
})
export class ApiService {
	headers = {
		'Content-Type': 'application/json',
		Authorization: 'Bearer ' + (localStorage.getItem('access-token') || '')
	};

	async doRequest(path: string, options: any): Promise<any> {
		const response = await fetch(`${environment.API_URL}${path}`, options);
		if (response.ok) {
			return response.json();
		} else {
			throw new Error(response.statusText);
		}
	}

	getRequest(path: string): Promise<any> {
		return this.doRequest(path, {
			method: 'GET',
			headers: this.headers
		});
	}

	postRequest(path: string, body: any): Promise<any> {
		return this.doRequest(path, {
			method: 'POST',
			headers: this.headers,
			body: JSON.stringify(body)
		});
	}

	putRequest(path: string, body: any): Promise<any> {
		return this.doRequest(path, {
			method: 'PUT',
			headers: this.headers,
			body: JSON.stringify(body)
		});
	}

	deleteRequest(path: string, body: any): Promise<any> {
		return this.doRequest(path, {
			method: 'DELETE',
			headers: this.headers,
			body: JSON.stringify(body)
		});
	}
}
