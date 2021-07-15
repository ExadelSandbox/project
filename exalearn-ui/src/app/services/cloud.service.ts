import { Injectable } from '@angular/core';
import { of } from 'rxjs';

@Injectable({
	providedIn: 'root'
})
export class CloudService {
	files: any = [
		// tslint:disable-next-line: max-line-length
		{
			url: 'https://ia801503.us.archive.org/15/items/TheBeatlesPennyLane_201805/The%20Beatles%20-%20Penny%20Lane.mp3',
			name: 'Penny Lane',
			artist: 'The Beatles'
		}
	];

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	getFiles() {
		return of(this.files);
	}
}
