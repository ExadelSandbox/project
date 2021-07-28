import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
import { TranslateModule } from '@ngx-translate/core';
import { CheckTestPageComponent } from './check-test-page.component';

@NgModule({
	declarations: [CheckTestPageComponent],
	imports: [MatButtonModule, DataTableModule, HeaderModule, FooterModule, MenuModule, TranslateModule],
	exports: [CheckTestPageComponent]
})
export class CheckTestPageModule {}
