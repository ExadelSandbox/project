import { Component } from '@angular/core';
import { MY_ASSIGNED_DATA } from '../../test-data/tables-mock-data';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-check-test-page',
	templateUrl: './check-test-page.component.html',
	styleUrls: ['./check-test-page.component.scss']
})
export class CheckTestPageComponent {
	data = MY_ASSIGNED_DATA;
	isDataAvailable = true;
	tableColumns = ['level', 'expire', 'check'];
}
