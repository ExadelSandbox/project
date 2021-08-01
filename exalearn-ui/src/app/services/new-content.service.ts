import { Injectable } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators, ValidatorFn } from '@angular/forms';

@Injectable({
	providedIn: 'root'
})
export class NewContentService {
	constructor(private fb: FormBuilder) {}

	public noWhitespaceValidator(control: FormControl): ValidatorFn | null | Object {
		const isWhitespace = (control.value || '').trim().length === 0;
		const isValid = !isWhitespace;
		return isValid ? null : { whitespace: true };
	}

	public addAnswerFields(amount: number, obj: any): void {
		for (let i = 0; i < amount; i++) {
			obj.push(
				this.fb.group({
					text: ['', [Validators.required, this.noWhitespaceValidator]],
					isCorrect: [false]
				})
			);
		}
	}

	public setIsCorrectProperty(form: FormGroup): void {
		const rad = document.getElementsByClassName('radioElem');
		for (let i = 0; i < rad.length; i++) {
			if (!rad.item(i)?.classList.contains('mat-radio-checked')) {
				form.value.answers[i].isCorrect = false;
			}
		}
	}

	public rightAnswerSelected(): boolean {
		let counter = 0;
		const rad = document.getElementsByClassName('radioElem');
		for (let i = 0; i < rad.length; i++) {
			if (!rad.item(i)?.classList.contains('mat-radio-checked')) {
				counter++;
			}
		}
		return counter == rad.length ? false : true;
	}
}
