import { Injectable } from '@angular/core';
import { ApiService } from './api.service';

@Injectable({
	providedIn: 'root'
})
export class TableService {
	constructor(private apiService: ApiService) {}

	getData(url: string) {
		return this.apiService.getRequest(url);
	}
}
