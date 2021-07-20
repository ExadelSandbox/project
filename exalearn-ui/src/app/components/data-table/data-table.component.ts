import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { TableService } from '../../services/table.service';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material/dialog';
import { AssignTestModalComponent } from '../assign-test-modal/assign-test-modal.component';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { EnglishLevels } from '../../Enums/enums';
import { ViewTestModalComponent } from '../view-test-modal/view-test-modal.component';

@Component({
	selector: 'app-data-table',
	templateUrl: './data-table.component.html',
	styleUrls: ['./data-table.component.scss']
})
export class DataTableComponent implements AfterViewInit, OnInit {
	@Input() displayedColumns: string[];
	@Input() dataType: string;
	constructor(private tableService: TableService, private location: Location, public dialog: MatDialog) {}
	// @ts-ignore
	applyFilter(event: Event): void {
		let filterValue = (event.target as HTMLInputElement).value;
		filterValue = filterValue.trim();
		filterValue = filterValue.toLowerCase();
		this.dataSource.filter = filterValue;
	}

	@ViewChild(MatPaginator) paginator: MatPaginator;
	@ViewChild(MatSort) sort: MatSort;

	goBack(): void {
		this.location.back();
	}
	openAssignDialog(el: { name: string; date: Date; level: EnglishLevels }): void {
		this.dialog.open(AssignTestModalComponent, {
			width: '50%',
			data: el
		});
	}
	openViewTestDialog(el: { name: string; date: Date; level: EnglishLevels }): void {
		this.dialog.open(ViewTestModalComponent, {
			width: '50%',
			data: el
		});
	}
	ELEMENT_DATA: { name: string }[] | { name: string; date: Date; level: EnglishLevels }[];
	dataSource: any;
	ngOnInit(): void {
		this.ELEMENT_DATA = this.tableService.getTableElements(this.dataType);
		this.dataSource = new MatTableDataSource(this.ELEMENT_DATA);
	}
	ngAfterViewInit(): void {
		this.dataSource.paginator = this.paginator;
		this.dataSource.sort = this.sort;
		this.dataSource.sortingDataAccessor = (data: any) => data.name;
	}
}
