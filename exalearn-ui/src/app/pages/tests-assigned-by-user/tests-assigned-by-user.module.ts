import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
import { TestsAssignedByUserComponent } from './tests-assigned-by-user.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [TestsAssignedByUserComponent],
	imports: [MatButtonModule, DataTableModule, HeaderModule, FooterModule, MenuModule, TranslateModule],
	exports: [TestsAssignedByUserComponent]
})
export class TestsAssignedByUserModule {}
