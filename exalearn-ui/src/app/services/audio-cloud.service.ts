import { Injectable } from '@angular/core';
import { AngularFireStorage } from '@angular/fire/storage';
import { of, Observable } from 'rxjs';
import { finalize } from 'rxjs/operators';

@Injectable({
	providedIn: 'root'
})
export class AudioCloudService {
	/* 
		There is Aleksey Olshevsky code.
		He uses it for his audition component.
		I'll remove it when we will receive data from the server 
	*/

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

	private url: string;

	constructor(private storage: AngularFireStorage) {}

	pushFileToStorage(file: File, path: string): Observable<any> {
		const id = Math.random().toString(36).substring(2);
		const filePath = `${path}/${id}${file.name}`;
		const storageRef = this.storage.ref(filePath);
		const uploadFile = this.storage.upload(filePath, file);

		uploadFile
			.snapshotChanges()
			.pipe(
				finalize(() => {
					storageRef.getDownloadURL().subscribe((downloadURL) => {
						this.url = downloadURL;
					});
				})
			)
			.subscribe();

		return uploadFile.percentageChanges();
	}

	getURL(): string {
		return this.url;
	}

	delete(url: string): void {
		const fileRef = this.storage.refFromURL(url);
		fileRef.delete();
	}
}
