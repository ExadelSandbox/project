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
			questionText: 'Her thinking leans ____ democracy',
			choices: ['with', 'towards', 'for', 'None of these'],
			selectedAnswer: null
		},
		{
			questionText: 'He got too tired _____ over work.',
			choices: ['because of', 'because off', 'on', 'for'],
			selectedAnswer: null
		},
		{
			questionText: '_____ his principles, he has to be very careful.',
			choices: ['with regard of', 'with regard on', 'with regard to', 'None of these'],
			selectedAnswer: null
		}
	];

	ngOnInit(): void {}
}
