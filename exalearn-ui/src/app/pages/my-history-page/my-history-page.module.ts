import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
import { MyHistoryPageComponent } from './my-history-page.component';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@NgModule({
	declarations: [MyHistoryPageComponent],
	imports: [
		MatButtonModule,
		DataTableModule,
		HeaderModule,
		FooterModule,
		MenuModule,
		TranslateModule,
		CommonModule,
		MatProgressSpinnerModule
	],
	exports: [MyHistoryPageComponent]
})
export class MyHistoryPageModule {}
