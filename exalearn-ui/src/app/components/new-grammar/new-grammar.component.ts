import { Component, OnInit, ViewChild } from '@angular/core';
import { FormGroup, Validators, FormArray, FormGroupDirective, FormBuilder } from '@angular/forms';

import { NewContentService } from '../../services/new-content.service';
import { ApiService } from '../../services/api.service';
import { EnglishLevels } from '../../enums/enums';
import { environment } from '../../../environments/environment.prod';
import { API_PATH } from '../../constants/api.constants';

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

	constructor(private fb: FormBuilder, private ncService: NewContentService, private apiServise: ApiService) {
		this.form = this.fb.group({
			question: ['', [Validators.required, Validators.minLength(2), this.ncService.noWhitespaceValidator]],
			level: ['', [Validators.required]],
			answers: this.fb.array([])
		});
	}

	ngOnInit(): void {
		this.ncService.addAnswerFields(environment.amountAnswers, this.answers);
	}

	get answers(): any {
		return <FormArray>this.form.get('answers');
	}

	submit(): void {
		this.ncService.setIsCorrectProperty(this.form);
		this.load = true;
		if (this.ncService.rightAnswerSelected()) {
			this.rightAnswer = false;
			setTimeout(() => {
				this.grammarForm.resetForm();
				this.load = false;
			}, 2000);
			console.log(this.form.value);
		} else {
			this.rightAnswer = true;
			this.load = false;
		}

		//TODO: delete code above when server is ready
		// and uncomment code lower
		/* this.ncService.setIsCorrectProperty(this.form);
		this.load = true;
		if (this.ncService.rightAnswerSelected()) {
			this.rightAnswer = false;
			void this.apiServise
				.postRequest(API_PATH.NEW_GRAMMAR, this.form.value)
				.then(() => {
					this.grammarForm.resetForm();
					this.load = false;
				})
				.catch(() => console.log('Sorry something wrong((('));
		} else {
			this.rightAnswer = true;
			this.load = false;
		} */
	}
}
