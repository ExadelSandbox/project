import { Injectable } from '@angular/core';
import { of } from 'rxjs';

@Injectable({
	providedIn: 'root'
})
export class CloudService {
	files: any = [
		{
			url: 'https://mp3.chillhop.com/serve.php/?mp3=10536',
			name: "She Won't Say",
			artist: 'Psalm Trees, Guillaume Muschalle'
		}
	];

	getFiles() {
		return of(this.files);
	}
}
