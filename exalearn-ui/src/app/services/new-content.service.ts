import { Injectable } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators, ValidatorFn, FormArray } from '@angular/forms';

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

	public setFalseAudition(form: FormGroup, index: number): void {
		setTimeout(() => {
			const rad = document.getElementsByClassName(`radioElem${index}`);
			for (let i = 0; i < rad.length; i++) {
				if (!rad.item(i)?.classList.contains('mat-radio-checked')) {
					form.value.exercises[index].answers[i].isCorrect = false;
				}
			}
		}, 0);
	}

	public rightAnwersSelectedAudition(form: FormGroup, amountQuestion: number, amountAnswers: number): string {
		const arr = [];
		let counter = 0;
		for (let i = 0; i < amountQuestion; i++) {
			for (let j = 0; j < amountAnswers; j++) {
				if (!form.value.exercises[i].answers[j].isCorrect) {
					counter++;
				}
			}
			arr.push(counter);
			counter = 0;
		}
		const notSelectedIndexes = arr.map((a, i) => a == 4 && i).filter((a) => a !== false);
		const result = notSelectedIndexes.map((item) => +item + 1);
		return result.join();
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

	public generateListeningForm(form: FormGroup, amountExercices: number, amountAnswers: number): void {
		const exer = <FormArray>form.get('exercises');
		for (let i = 0; i < amountExercices; i++) {
			exer.push(
				this.fb.group({
					question: ['', [Validators.required, Validators.minLength(2), this.noWhitespaceValidator]],
					answers: this.addAnswerFieldsAudition(amountAnswers)
				})
			);
		}
	}

	public addAnswerFieldsAudition(amount: number): FormArray {
		const arr = this.fb.array([]);
		for (let i = 0; i < amount; i++) {
			arr.push(
				this.fb.group({
					text: ['', [Validators.required]],
					isCorrect: [false]
				})
			);
		}
		return arr;
	}
}
