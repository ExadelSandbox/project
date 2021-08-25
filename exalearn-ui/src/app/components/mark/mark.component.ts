import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';

@Component({
	selector: 'app-mark',
	templateUrl: './mark.component.html',
	styleUrls: ['./mark.component.scss']
})
export class MarkComponent implements OnInit {
	// marks: number[] = new Array(10);
	@Input() marks: number[];
	currentIndex = 1;

	@Output() changed = new EventEmitter<number>();

	selectMark(mark: number): void {
		this.currentIndex = mark;
		this.changed.emit(mark);
	}

	ngOnInit(): void {}
}
