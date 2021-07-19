import { NgModule } from '@angular/core';
import { AssignTestPageComponent } from './assign-test-page.component';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
@NgModule({
	declarations: [AssignTestPageComponent],
	imports: [MatButtonModule, DataTableModule]
})
export class AssignTestPageModule {}
