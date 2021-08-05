import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { FormGroup, Validators, FormArray, FormGroupDirective, FormBuilder } from '@angular/forms';

import { NewContentService } from '../../services/new-content.service';
import { ApiService } from '../../services/api.service';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { EnglishLevels } from '../../enums/enums';
import { environment } from '../../../environments/environment.prod';
import { API_PATH } from 'src/app/constants/api.constants';

@Component({
	selector: 'app-new-listening',
	templateUrl: './new-listening.component.html',
	styleUrls: ['./new-listening.component.scss']
})
export class NewListeningComponent implements OnInit {
	@ViewChild('fileInput')
	fileInput: ElementRef;

	@ViewChild(FormGroupDirective, { static: false })
	listeningForm: FormGroupDirective;

	form: FormGroup;
	levels = Object.values(EnglishLevels);
	percentage = 0;
	url: string;
	fileName: string;
	loadAudio: boolean;
	loadServer: boolean;
	currentExercise = 0;
	isURL: boolean;
	notSelectedAnswers: string;

	constructor(
		private fb: FormBuilder,
		private ncService: NewContentService,
		private apiServise: ApiService,
		private audioService: AudioCloudService
	) {
		this.form = this.fb.group({
			level: ['', [Validators.required]],
			exercises: this.fb.array([])
		});
	}

	ngOnInit(): void {
		this.ncService.generateListeningForm(this.form, environment.amountQuestions, environment.amountAnswers);
	}

	get exercises(): any {
		return <FormArray>this.form.get('exercises');
	}

	uploadToCloud(event: any): void {
		const file = event.target.files[0];
		this.fileName = file.name;
		this.loadAudio = true;

		void this.audioService.uploadAudio(file, environment.cloudTest).then((url: string) => {
			this.url = url;
			this.loadAudio = false;
		});

		this.audioService.getPercentage().subscribe(
			(percentage) => {
				this.percentage = Math.round(percentage ? percentage : 0);
			},
			(error) => {
				console.log(error);
			}
		);
	}

	openFileInput(): void {
		document.getElementById('fileInput')?.click();
	}

	resetAudioUpload(): void {
		this.url = '';
		this.fileName = '';
		this.percentage = 0;
		this.fileInput.nativeElement.value = '';
	}

	deleteFile(url: string): void {
		this.audioService.deleteAudio(url);
		this.resetAudioUpload();
	}

	setCurrentExercise(index: number): void {
		this.currentExercise = index;
	}

	setFalse(): void {
		this.ncService.setFalseAudition(this.form, this.currentExercise);
	}

	submit(): void {
		this.loadServer = true;
		this.notSelectedAnswers = this.ncService.rightAnwersSelectedAudition(
			this.form,
			environment.amountQuestions,
			environment.amountAnswers
		);

		if (!this.url) {
			this.isURL = true;
			this.loadServer = false;
		} else if (this.notSelectedAnswers) {
			this.isURL = false;
			this.notSelectedAnswers = this.ncService.rightAnwersSelectedAudition(
				this.form,
				environment.amountQuestions,
				environment.amountAnswers
			);
			this.loadServer = false;
		} else {
			this.form.value.url = this.url;
			this.isURL = false;

			setTimeout(() => {
				console.log(this.form.value);
				this.listeningForm.resetForm();
				this.resetAudioUpload();
				this.loadServer = false;
			}, 2000);

			//TODO
			//Delet setTimeout above and uncomment code below. When server is ready

			/* 
			void this.apiServise
				.postRequest(API_PATH.NEW_AUDITION, this.form.value)
				.then(() => {
					this.listeningForm.resetForm();
					this.resetAudioUpload();
					this.loadServer = false;
				})
				.catch(() => console.log('Sorry something wrong(((')); 
			*/
		}
	}
}
