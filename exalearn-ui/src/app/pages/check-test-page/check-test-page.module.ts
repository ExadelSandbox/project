import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { DataTableModule } from '../../components/data-table/data-table.module';
import { HeaderModule } from '../../components/header/header.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MenuModule } from '../../components/menu/menu.module';
import { TranslateModule } from '@ngx-translate/core';
import { CheckTestPageComponent } from './check-test-page.component';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { CommonModule } from '@angular/common';
import { CheckTestItemPageModule } from '../check-test-item-page/check-test-item-page.module';

@NgModule({
	declarations: [CheckTestPageComponent],
	imports: [
		MatButtonModule,
		DataTableModule,
		HeaderModule,
		FooterModule,
		MenuModule,
		TranslateModule,
		MatProgressSpinnerModule,
		CommonModule,
		CheckTestItemPageModule
	],
	exports: [CheckTestPageComponent]
})
export class CheckTestPageModule {}
