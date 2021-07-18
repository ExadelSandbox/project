import { NgModule } from '@angular/core';
import { MatPaginatorModule } from '@angular/material/paginator';
import { AssignTestPageComponent } from './assign-test-page.component';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSortModule } from '@angular/material/sort';
import { AssignTestModalModule } from '../../components/assign-test-modal/assign-test-modal.module';
@NgModule({
	declarations: [AssignTestPageComponent],
	imports: [MatPaginatorModule, MatTableModule, MatInputModule, MatButtonModule, MatSortModule, AssignTestModalModule]
})
export class AssignTestPageModule {}
