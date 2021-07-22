import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { PassedTest } from '../../interfaces/interfaces';

@Component({
	selector: 'app-view-test-modal',
	templateUrl: './view-test-modal.component.html',
	styleUrls: ['./view-test-modal.component.scss']
})
export class ViewTestModalComponent implements OnInit {
	constructor(@Inject(MAT_DIALOG_DATA) public data: PassedTest) {}

	ngOnInit(): void {}
}
