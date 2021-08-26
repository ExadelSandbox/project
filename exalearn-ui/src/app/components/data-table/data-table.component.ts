import { AfterViewInit, Component, DoCheck, Input, OnInit, ViewChild, OnChanges } from '@angular/core';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material/dialog';
import { AssignTestModalComponent } from '../assign-test-modal/assign-test-modal.component';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { ViewTestModalComponent } from '../view-test-modal/view-test-modal.component';
import {
	PassedTest,
	User,
	Assignment,
	isUser,
	UserBack,
	isPassedTest,
	CheckCoachQuestion
} from '../../interfaces/interfaces';
import { StartTestModalComponent } from '../start-test-modal/start-test-modal.component';
import { EnglishLevels } from '../../enums/enums';
import { Router } from '@angular/router';
import { StartCheckTestComponent } from '../start-check-test/start-check-test.component';
import { QuestionEditModalComponent } from '../question-edit-modal/question-edit-modal.component';

@Component({
	selector: 'app-data-table',
	templateUrl: './data-table.component.html',
	styleUrls: ['./data-table.component.scss']
})
export class DataTableComponent implements AfterViewInit, OnInit, OnChanges {
	dataSource: MatTableDataSource<PassedTest | UserBack>;
	EnglishLevels: any = EnglishLevels;
	@Input() displayedColumns: string[];
	@Input() data: any;
	@Input() displaySearch = true;
	@ViewChild(MatPaginator) paginator: MatPaginator;
	@ViewChild(MatSort) sort: MatSort;

	constructor(private location: Location, public dialog: MatDialog, public router: Router) {}

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

	ngOnChanges() {
		const ELEMENT_DATA: any = this.data;
		this.dataSource = new MatTableDataSource(ELEMENT_DATA);
		this.dataSource.sort = this.sort;
		this.dataSource.paginator = this.paginator;
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
			data: el,
			autoFocus: false,
			restoreFocus: false
		});
	}

	openViewTestDialog(el: PassedTest): void {
		this.dialog.open(ViewTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: el,
			autoFocus: false,
			restoreFocus: false
		});
	}

	openStartTestDialog(el: Assignment): void {
		this.dialog.open(StartTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: el,
			autoFocus: false,
			restoreFocus: false
		});
	}

	openCheckTest(el: Assignment): void {
		this.dialog.open(StartCheckTestComponent, {
			width: '100%',
			maxWidth: 500,
			data: el,
			autoFocus: false,
			restoreFocus: false
		});
	}

	openViewQuestion(el: Assignment): void {
		this.dialog.open(ViewTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: el,
			autoFocus: false,
			restoreFocus: false
		});
	}
	openEditQuestion(question: CheckCoachQuestion): void {
		this.dialog.open(QuestionEditModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				modalHeader: 'QUESTION_EDIT_MODAL.EDIT_OR_DELETE_QUESTION',
				questionName: 'QUESTION_EDIT_MODAL.QUESTION',
				answer: question
			},
			autoFocus: false,
			restoreFocus: false
		});
	}
	passedColor(passed: string) {
		return passed == 'Passed' ? 'green' : 'red';
	}

	markColor(mark: number) {
		return mark < 7 ? 'red' : 'green';
	}
}
