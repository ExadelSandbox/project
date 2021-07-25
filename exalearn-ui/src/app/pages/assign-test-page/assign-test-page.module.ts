import { NgModule } from '@angular/core';
import { AssignTestPageComponent } from './assign-test-page.component';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
@NgModule({
	declarations: [AssignTestPageComponent],
	imports: [MatButtonModule, DataTableModule, HeaderModule, MenuModule, FooterModule],
	exports: [AssignTestPageComponent]
})
export class AssignTestPageModule {}
