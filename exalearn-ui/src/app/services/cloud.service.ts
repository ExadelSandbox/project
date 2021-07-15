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
		// },
		// {
		// 	url: 'https://mp3.chillhop.com/serve.php/?mp3=11227',
		// 	name: 'Toofpick',
		// 	artist: 'Blue Wednesday, Shopan'
		// },
		// { url: 'https://mp3.chillhop.com/serve.php/?mp3=10263', name: 'Wildlife', artist: 'Philanthrope, chromonicci' },
		// {
		// 	url: 'https://mp3.chillhop.com/serve.php/?mp3=9923',
		// 	name: 'What Was Before',
		// 	artist: 'Philanthrope, Leavv'
		// },
		// {
		// 	url: 'https://mp3.chillhop.com/serve.php/?mp3=11247',
		// 	name: 'Loving Someone You Lost',
		// 	artist: 'The Field Tapes, tender spring, Nuum'
		// }
	];

	getFiles() {
		return of(this.files);
	}
}
