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
			id: 0,
			questionText: 'Her thinking leans ____ democracy',
			choices: ['with', 'towards', 'for', 'None of these'],
			userAnswer: null
		},
		{
			id: 1,
			questionText: 'He got too tired _____ over work.',
			choices: ['because of', 'because off', 'on', 'for'],
			userAnswer: null
		},
		{
			id: 2,
			questionText: '_____ his principles, he has to be very careful.',
			choices: ['with regard of', 'with regard on', 'with regard to', 'None of these'],
			userAnswer: null
		}
	];
	currentId = 0;
	ngOnInit(): void {}
}
