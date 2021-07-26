import { NgModule } from '@angular/core';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSortModule } from '@angular/material/sort';
import { AssignTestModalModule } from '../assign-test-modal/assign-test-modal.module';
import { DataTableComponent } from './data-table.component';
import { BrowserModule } from '@angular/platform-browser';
import { ViewTestModalModule } from '../view-test-modal/view-test-modal.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [DataTableComponent],
	exports: [DataTableComponent],
	imports: [
		MatPaginatorModule,
		MatTableModule,
		MatInputModule,
		MatButtonModule,
		MatSortModule,
		AssignTestModalModule,
		ViewTestModalModule,
		BrowserModule,
		TranslateModule
	]
})
export class DataTableModule {}
