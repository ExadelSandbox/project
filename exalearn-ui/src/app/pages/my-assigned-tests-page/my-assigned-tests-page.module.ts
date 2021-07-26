import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
import { MyAssignedTestsPageComponent } from './my-assigned-tests-page.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [MyAssignedTestsPageComponent],
	imports: [MatButtonModule, DataTableModule, HeaderModule, FooterModule, MenuModule, TranslateModule],
	exports: [MyAssignedTestsPageComponent]
})
export class MyAssignedTestsPageModule {}
