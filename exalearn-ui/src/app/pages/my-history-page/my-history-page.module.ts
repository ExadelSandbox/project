import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
import { MyHistoryPageComponent } from './my-history-page.component';

@NgModule({
	declarations: [MyHistoryPageComponent],
	imports: [MatButtonModule, DataTableModule, HeaderModule, FooterModule, MenuModule],
	exports: [MyHistoryPageComponent]
})
export class MyHistoryPageModule {}
