import { Injectable } from '@angular/core';
import { AngularFireStorage, AngularFireStorageReference, AngularFireUploadTask } from '@angular/fire/storage';
import { of, Observable } from 'rxjs';
import { finalize } from 'rxjs/operators';

@Injectable({
	providedIn: 'root'
})
export class AudioCloudService {
	private storageRef: AngularFireStorageReference;
	private uploadFile: AngularFireUploadTask;
	public files: [{ url: string | undefined }];

	constructor(private storage: AngularFireStorage) {}

	setFiles(audioUrl?: string) {
		this.files = [{ url: audioUrl }];
	}

	getFiles() {
		return of(this.files);
	}

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
