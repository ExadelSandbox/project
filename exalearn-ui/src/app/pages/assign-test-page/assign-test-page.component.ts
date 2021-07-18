import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { TableService } from '../../services/table.service';
import { MatSort } from '@angular/material/sort';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material/dialog';
import { AssignTestModalComponent } from '../../components/assign-test-modal/assign-test-modal.component';

@Component({
	selector: 'app-assign-test-page',
	templateUrl: './assign-test-page.component.html',
	styleUrls: ['./assign-test-page.component.scss']
})
export class AssignTestPageComponent implements AfterViewInit {
	ELEMENT_DATA = this.tableService.getTableElements();

	displayedColumns: string[] = ['user', 'assign test'];
	dataSource = new MatTableDataSource(this.ELEMENT_DATA);

	@ViewChild(MatPaginator) paginator: MatPaginator;
	@ViewChild(MatSort) sort: MatSort;

	applyFilter(event: Event): void {
		let filterValue = (event.target as HTMLInputElement).value;
		filterValue = filterValue.trim();
		filterValue = filterValue.toLowerCase();
		this.dataSource.filter = filterValue;
	}

	goBack() {
		this.location.back();
	}

	constructor(private tableService: TableService, private location: Location, public dialog: MatDialog) {}

	openDialog(el: { name: string }): void {
		console.log(el);
		const dialogRef = this.dialog.open(AssignTestModalComponent, {
			width: '50%',
			data: el
		});

		dialogRef.afterClosed().subscribe((result) => {
			console.log('The dialog was closed --- ', result);
		});
	}

	ngAfterViewInit(): void {
		this.dataSource.paginator = this.paginator;
		this.dataSource.sort = this.sort;
		this.dataSource.sortingDataAccessor = (data) => data.name;
	}
}
