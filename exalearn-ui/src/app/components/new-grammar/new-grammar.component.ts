import { Component, OnInit, ViewChild } from '@angular/core';
import { FormGroup, Validators, FormArray, FormGroupDirective, FormBuilder } from '@angular/forms';

import { NewContentService, onlyLatinSymbols, noWhitespaceValidator } from '../../services/new-content.service';
import { ApiService } from '../../services/api.service';
import { EnglishLevels } from '../../enums/enums';
import { environment } from '../../../environments/environment.prod';
import { API_PATH } from '../../constants/api.constants';
import { NotificationService } from '../../services/notification.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
	selector: 'app-new-grammar',
	templateUrl: './new-grammar.component.html',
	styleUrls: ['./new-grammar.component.scss']
})
export class NewGrammarComponent implements OnInit {
	@ViewChild(FormGroupDirective, { static: false })
	grammarForm: FormGroupDirective;

	form: FormGroup;
	levels = Object.values(EnglishLevels);
	load = false;
	rightAnswer = false;
	isValid = true;
	private translateService: TranslateService;

	constructor(
		private fb: FormBuilder,
		private ncService: NewContentService,
		private apiServise: ApiService,
		private notificationService: NotificationService,
		translateService: TranslateService
	) {
		this.translateService = translateService;
		this.form = this.fb.group({
			question: ['', [Validators.required, Validators.minLength(2), noWhitespaceValidator, onlyLatinSymbols]],
			levelType: ['', [Validators.required]],
			answers: this.fb.array([])
		});
	}

	ngOnInit(): void {
		this.ncService.addAnswerFields(environment.amountAnswers, this.answers);
	}

	get answers(): any {
		return <FormArray>this.form.get('answers');
	}

	validFields(): boolean {
		this.trimForm();
		return this.form.valid;
	}

	trimForm(): void {
		const question = this.form.get('question');
		const trimmedQuestion: string = question?.value.trim();
		this.answers['controls'].forEach((element: FormGroup) => {
			element.controls.text.setValue(element.controls.text.value.trim());
		});
		question?.setValue(trimmedQuestion[0].toUpperCase() + trimmedQuestion.substr(1));
	}

	submit(): void {
		this.ncService.setIsCorrectProperty(this.form);
		this.isValid = this.validFields();

		if (!this.ncService.rightAnswerSelected()) {
			this.rightAnswer = true;
		} else if (this.isValid) {
			this.load = true;
			this.rightAnswer = false;
			void this.apiServise
				.postRequest(API_PATH.NEW_GRAMMAR, this.form.value)
				.then(() => {
					this.notificationService.successPopUp();
					this.grammarForm.resetForm();
				})
				.catch(() =>
					this.notificationService.errorPopUp(this.translateService.instant('NOTIFICATION.ERROR_TRY_AGAIN'))
				)
				.finally(() => {
					this.load = false;
				});
		}
	}
}
