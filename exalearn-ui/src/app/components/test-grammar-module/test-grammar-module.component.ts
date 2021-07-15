import { Component, OnInit } from '@angular/core';
import { Question } from 'src/app/interfaces/interfaces';

@Component({
	selector: 'app-test-grammar-module',
	templateUrl: './test-grammar-module.component.html',
	styleUrls: ['./test-grammar-module.component.scss']
})
export class TestGrammarModuleComponent implements OnInit {
	questions: Question[] = [
		{
			id: 1234,
			questionText: 'Her thinking leans ____ democracy',
			choices: ['with', 'towards', 'for', 'None of these'],
			userAnswer: null,
			index: undefined
		},
		{
			id: 1123,
			questionText: 'He got too tired _____ over work.',
			choices: ['because of', 'because off', 'on', 'for'],
			userAnswer: null,
			index: undefined
		},
		{
			id: 23321,
			questionText: '_____ his principles, he has to be very careful.',
			choices: ['with regard of', 'with regard on', 'with regard to', 'None of these'],
			userAnswer: null,
			index: undefined
		}
	];
	currentIndex = 0;
	ngOnInit(): void {}
}
