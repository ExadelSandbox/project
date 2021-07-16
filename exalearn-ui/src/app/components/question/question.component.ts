import { Component, Input } from '@angular/core';
import { Question } from '../../interfaces/interfaces';

@Component({
	selector: 'app-question',
	templateUrl: './question.component.html',
	styleUrls: ['./question.component.scss']
})
export class QuestionComponent {
	@Input() question: Question;
}
