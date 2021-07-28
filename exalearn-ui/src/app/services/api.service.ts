import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

@Injectable({
	providedIn: 'root'
})
export class ApiService {
	headers = {
		'Content-Type': 'application/json'
	};

	async getRequest(path: string): Promise<any> {
		const response = await fetch(`${environment.API_URL}${path}`, {
			method: 'GET',
			headers: this.headers
		});
		if (response.ok) {
			return response.json();
		} else {
			throw new Error(response.statusText);
		}
	}

	async postRequest(path: string, body: any): Promise<any> {
		const response = await fetch(`${environment.API_URL}${path}`, {
			method: 'POST',
			headers: this.headers,
			body: JSON.stringify(body)
		});
		if (response.ok) {
			return response.json();
		} else {
			throw new Error(response.statusText);
		}
	}

	async putRequest(path: string, body: any): Promise<any> {
		const response = await fetch(`${environment.API_URL}${path}`, {
			method: 'PUT',
			headers: this.headers,
			body: JSON.stringify(body)
		});
		if (response.ok) {
			return response.json();
		} else {
			throw new Error(response.statusText);
		}
	}

	async deleteRequest(path: string, body: any): Promise<any> {
		const response = await fetch(`${environment.API_URL}${path}`, {
			method: 'DELETE',
			headers: this.headers,
			body: JSON.stringify(body)
		});
		if (response.ok) {
			return response.json();
		} else {
			throw new Error(response.statusText);
		}
	}
}
