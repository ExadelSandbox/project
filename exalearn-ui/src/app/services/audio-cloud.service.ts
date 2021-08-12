import { Injectable } from '@angular/core';
import { AngularFireStorage, AngularFireStorageReference, AngularFireUploadTask } from '@angular/fire/storage';
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

	private storageRef: AngularFireStorageReference;
	private uploadFile: AngularFireUploadTask;

	constructor(private storage: AngularFireStorage) {}

	async uploadAudio(file: File, path: string): Promise<any> {
		const id = Math.random().toString(36).substring(2);
		const filePath = `${path}/${id}${file.name}`;

		return new Promise((resolve, reject) => {
			this.storageRef = this.storage.ref(filePath);
			this.uploadFile = this.storage.upload(filePath, file);

			this.uploadFile.task.on(
				'state_changed',
				null,
				(error) => {
					reject(error);
				},
				() => {
					this.uploadFile
						.snapshotChanges()
						.pipe(
							finalize(() => {
								this.storageRef.getDownloadURL().subscribe((downloadURL: string) => {
									resolve(downloadURL);
								});
							})
						)
						.subscribe();
				}
			);
		});
	}

	getPercentage(): Observable<any> {
		return this.uploadFile.percentageChanges();
	}

	deleteAudio(url: string): void {
		const fileRef = this.storage.refFromURL(url);
		fileRef.delete();
	}
}
