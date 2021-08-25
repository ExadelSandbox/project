import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { FormGroup, Validators, FormArray, FormGroupDirective, FormBuilder, AbstractControl } from '@angular/forms';

import { NewContentService } from '../../services/new-content.service';
import { ApiService } from '../../services/api.service';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { EnglishLevels } from '../../enums/enums';
import { environment } from '../../../environments/environment.prod';
import { API_PATH } from 'src/app/constants/api.constants';

import { NotificationService } from '../../services/notification.service';
import { NewAuditionService } from '../../services/new-audition.service';
import { TranslateService } from '@ngx-translate/core';

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
	validForm = true;
	invalidFields = false;

	constructor(
		private fb: FormBuilder,
		private ncService: NewContentService,
		private apiServise: ApiService,
		private audioService: AudioCloudService,
		private notificationService: NotificationService,
		private nAuditionService: NewAuditionService,
		private translateService: TranslateService
	) {
		this.translateService = translateService;
		this.form = this.fb.group({
			levelType: ['', [Validators.required]],
			exercises: this.fb.array([])
		});
	}

	ngOnInit(): void {
		this.ncService.generateListeningForm(this.form, environment.amountQuestions, environment.amountAnswers);
	}

	get exercises(): FormArray {
		return this.form.get('exercises') as FormArray;
	}

	getAnswers(index: number): AbstractControl[] {
		const arr = this.exercises['controls'][index].get('answers') as FormArray;
		return arr['controls'];
	}

	uploadToCloud(event: Event): void {
		const target = event.target as HTMLInputElement;
		const file: File = (target.files as FileList)[0];
		this.fileName = file.name;
		this.loadAudio = true;

		void this.audioService
			.uploadAudio(file, environment.cloudTest)
			.then((url: string) => {
				this.url = url;
				this.loadAudio = false;
			})
			.catch(() => {
				this.notificationService.errorPopUp(this.translateService.instant('NOTIFICATION.ERROR_TRY_AGAIN'));
				this.loadAudio = false;
			});

		this.audioService.getPercentage().subscribe(
			(percentage) => {
				this.percentage = Math.round(percentage ? percentage : 0);
			},
			(error) => {
				this.loadAudio = false;
				this.notificationService.errorPopUp(this.translateService.instant('NOTIFICATION.ERROR_TRY_AGAIN'));
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

	checkValidForm(): boolean {
		let isValid = true;
		if (!this.url) {
			this.isURL = true;
			isValid = false;
		} else if (this.notSelectedAnswers) {
			this.isURL = false;
			isValid = false;
		} else if (!this.validFields()) {
			this.invalidFields = true;
			this.isURL = false;
			isValid = false;
		} else {
			this.form.value.url = this.url;
			this.isURL = false;
			this.invalidFields = false;
			isValid = true;
		}
		return isValid;
	}

	trimForm(): void {
		const exers = Array.from(this.exercises['controls']);
		exers.forEach((element) => {
			const trimmedQuestion: string = element.get('question')?.value.trim();
			element.get('question')?.setValue(trimmedQuestion[0].toUpperCase() + trimmedQuestion.substr(1));
			const arr: FormArray = element.get('answers') as FormArray;
			arr['controls'].forEach((element) => {
				element.get('text')?.setValue(element.get('text')?.value.trim());
			});
		});
	}

	validFields(): boolean {
		this.trimForm();
		return this.form.valid;
	}

	submit(): void {
		this.notSelectedAnswers = this.ncService.rightAnwersSelectedAudition(
			this.form,
			environment.amountQuestions,
			environment.amountAnswers
		);

		this.validForm = this.checkValidForm();

		if (!this.validForm) {
			this.loadServer = false;
		} else {
			this.loadServer = true;
			this.trimForm();
			void this.apiServise
				.postRequest(API_PATH.NEW_AUDITION, this.nAuditionService.transformData(this.form.value))
				.then(() => {
					this.notificationService.successPopUp();
					this.listeningForm.resetForm();
					this.resetAudioUpload();
				})
				.catch(() => {
					this.notificationService.errorPopUp(this.translateService.instant('NOTIFICATION.ERROR_TRY_AGAIN'));
				})
				.finally(() => {
					this.loadServer = false;
				});
		}
	}
}
