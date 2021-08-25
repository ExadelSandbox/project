import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { EnglishLevels, QuestionTypes } from '../../enums/enums';

@Component({
	selector: 'app-mark',
	templateUrl: './mark.component.html',
	styleUrls: ['./mark.component.scss']
})
export class MarkComponent implements OnInit {
	@Input() marks: number[];
	@Input() questionTest: boolean;
	@Input() questionType: boolean;
	currentIndex = 1;
	englishLevels = Object.keys(EnglishLevels);
	questionTypes = Object.keys(QuestionTypes);

	@Output() changed = new EventEmitter<number>();

	selectMark(mark: number): void {
		this.currentIndex = mark;
		this.changed.emit(mark);
	}

	ngOnInit(): void {}
}
