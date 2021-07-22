import { NgModule } from '@angular/core';
import { AllHistoryPageComponent } from './all-history-page.component';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';

@NgModule({
	declarations: [AllHistoryPageComponent],
	imports: [MatButtonModule, DataTableModule]
})
export class AllHistoryPageModule {}
