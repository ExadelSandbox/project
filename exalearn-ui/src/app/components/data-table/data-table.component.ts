import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material/dialog';
import { AssignTestModalComponent } from '../assign-test-modal/assign-test-modal.component';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { ViewTestModalComponent } from '../view-test-modal/view-test-modal.component';
import { PassedTest, User, Assignment, isUser, UserBack, isPassedTest } from '../../interfaces/interfaces';
import { StartTestModalComponent } from '../start-test-modal/start-test-modal.component';

@Component({
	selector: 'app-data-table',
	templateUrl: './data-table.component.html',
	styleUrls: ['./data-table.component.scss']
})
export class DataTableComponent implements AfterViewInit, OnInit {
	dataSource: MatTableDataSource<PassedTest | UserBack>;

	@Input() displayedColumns: string[];
	@Input() data: any;
	@Input() displaySearch = true;
	@ViewChild(MatPaginator) paginator: MatPaginator;
	@ViewChild(MatSort) sort: MatSort;

	constructor(private location: Location, public dialog: MatDialog) {}

	ngOnInit(): void {
		const monthNames = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
		const ELEMENT_DATA: any = this.data;
		this.dataSource = new MatTableDataSource(ELEMENT_DATA);
		this.dataSource.filterPredicate = (data, filter: string) => {
			if (isUser(data)) {
				return data.firstName.concat(' ', data.lastName).trim().toLowerCase().includes(filter);
			} else if (isPassedTest(data)) {
				const date = monthNames[data.date.getMonth()].concat(
					' ',
					data.date.getDate().toString(),
					', ',
					data.date.getFullYear().toString()
				);
				return data.username.concat(' ', data.level, ' ', date).trim().toLowerCase().includes(filter);
			} else {
				return false;
			}
		};
	}

	ngAfterViewInit(): void {
		this.dataSource.paginator = this.paginator;
		this.dataSource.sort = this.sort;
	}

	applyFilter(event: Event): void {
		this.dataSource.filter = (event.target as HTMLInputElement).value.trim().toLowerCase();
	}

	goBack(): void {
		this.location.back();
	}

	openAssignDialog(el: User): void {
		this.dialog.open(AssignTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: el
		});
	}

	openViewTestDialog(el: PassedTest): void {
		this.dialog.open(ViewTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: el
		});
	}

	openStartTestDialog(el: Assignment): void {
		this.dialog.open(StartTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: el
		});
	}

	openCheckTest(el: Assignment): void {}

	passedColor(passed: string) {
		return passed == 'Passed' ? 'green' : 'red';
	}

	markColor(mark: number) {
		return mark < 35 ? 'red' : 'green';
	}
}
