import { NgModule } from '@angular/core';
import { MatPaginatorModule } from '@angular/material/paginator';
import { AssignTestPageComponent } from './assign-test-page.component';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSortModule } from '@angular/material/sort';
@NgModule({
	declarations: [AssignTestPageComponent],
	imports: [MatPaginatorModule, MatTableModule, MatInputModule, MatButtonModule, MatSortModule]
})
export class AssignTestPageModule {}
