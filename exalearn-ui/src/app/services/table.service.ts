import { Injectable } from '@angular/core';
import { EnglishLevels } from '../Enums/enums';

@Injectable({
	providedIn: 'root'
})
export class TableService {
	USERS_DATA: { name: string }[] = [
		{ name: 'Semen' },
		{ name: 'Kristie' },
		{ name: 'Danya' },
		{ name: 'Polina' },
		{ name: 'Anna' }
	];
	TESTS_DATA: { name: string; date: Date; level: EnglishLevels }[] = [
		{ name: 'Dima', date: new Date('2021-05-17T04:24:00'), level: EnglishLevels.B2 },
		{ name: 'Serega', date: new Date('2021-08-17T03:25:00'), level: EnglishLevels.B1 },
		{ name: 'Max', date: new Date('2021-09-17T06:24:00'), level: EnglishLevels.C2 },
		{ name: 'Kirill', date: new Date('2021-05-17T06:23:00'), level: EnglishLevels.C1 }
	];
	getTableElements(dataType: string): { name: string }[] | { name: string; date: Date; level: EnglishLevels }[] {
		switch (dataType) {
			case 'user':
				return this.USERS_DATA;
				break;
			case 'test':
				return this.TESTS_DATA;
				break;
			default:
				return [];
		}
	}
}
