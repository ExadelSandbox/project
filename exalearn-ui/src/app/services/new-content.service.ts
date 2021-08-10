import { Injectable } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators, ValidatorFn, FormArray } from '@angular/forms';
import { elementAt } from 'rxjs/operators';

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
		const rad = Array.from(document.getElementsByClassName('radioElem'));

		rad.forEach((item, index) => {
			if (!item.classList.contains('mat-radio-checked')) {
				form.value.answers[index].isCorrect = false;
			}
		});
	}

	public setFalseAudition(form: FormGroup, index: number): void {
		setTimeout(() => {
			const rad = Array.from(document.getElementsByClassName(`radioElem${index}`));
			const arr = form.value.exercises[index].answers;
			rad.forEach((item, index) => {
				if (!item.classList.contains('mat-radio-checked')) {
					arr[index].isCorrect = false;
				}
			});
		}, 0);
	}

	public rightAnwersSelectedAudition(form: FormGroup, amountQuestion: number, amountAnswers: number): string {
		const arr: number[] = [];
		let counter = 0;
		const exercises = form.value.exercises;

		exercises.forEach((i: any) => {
			i.answers.forEach((j: any) => {
				if (!j.isCorrect) {
					counter++;
				}
			});
			arr.push(counter);
			counter = 0;
		});

		const notSelectedIndexes = arr.map((a, i) => a == amountAnswers && i).filter((a) => a !== false);
		const result = notSelectedIndexes.map((item) => +item + 1);
		return result.join();
	}

	public rightAnswerSelected(): boolean {
		let counter = 0;
		const rad = Array.from(document.getElementsByClassName('radioElem'));

		rad.forEach((element) => {
			if (!element.classList.contains('mat-radio-checked')) {
				counter++;
			}
		});

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
		const amountArr = new Array(amount);
		let arr = this.fb.array([...amountArr]);
		const result = arr.controls.map(() =>
			this.fb.group({
				text: ['', [Validators.required, this.noWhitespaceValidator]],
				isCorrect: [false]
			})
		);

		arr = this.fb.array([...result]);
		return arr;
	}
}
