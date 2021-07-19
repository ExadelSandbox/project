//TODO: remove test data after back-end integration
import { Injectable } from '@angular/core';

@Injectable({
	providedIn: 'root'
})
export class TableService {
	ELEMENT_DATA: { name: string }[] = [{ name: 'Dima' }, { name: 'Serega' }, { name: 'Max' }, { name: 'Kirill' }];
	getTableElements(): { name: string }[] {
		return this.ELEMENT_DATA;
	}
}
