import { NgModule } from '@angular/core';
import { AllHistoryPageComponent } from './all-history-page.component';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [AllHistoryPageComponent],
	imports: [MatButtonModule, DataTableModule, HeaderModule, FooterModule, MenuModule, TranslateModule],
	exports: [AllHistoryPageComponent]
})
export class AllHistoryPageModule {}
