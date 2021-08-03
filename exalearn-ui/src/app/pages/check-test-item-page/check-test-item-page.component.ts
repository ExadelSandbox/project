import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { MatDialog } from '@angular/material/dialog';

@Component({
	selector: 'app-check-test-item-page',
	templateUrl: './check-test-item-page.component.html',
	styleUrls: ['./check-test-item-page.component.scss']
})
export class CheckTestItemPageComponent implements OnInit {
	constructor(public translateService: TranslateService, public dialog: MatDialog) {}
	ngOnInit(): void {}
}
