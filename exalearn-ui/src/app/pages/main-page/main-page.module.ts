import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { MainPageComponent } from './main-page.component';
import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { TranslateModule } from '@ngx-translate/core';
import { FooterModule } from '../../components/footer/footer.module';
import { HeaderModule } from '../../components/header/header.module';
import { MenuModule } from '../../components/menu/menu.module';
import { AllHistoryPageModule } from '../all-history-page/all-history-page.module';
import { TestPageModule } from '../test-page/test-page.module';
import { AssignTestPageModule } from '../assign-test-page/assign-test-page.module';
import { CreatePageModule } from '../create-page/create-page.module';

@NgModule({
	declarations: [MainPageComponent],
	imports: [
		BrowserModule,
		AllHistoryPageModule,
		MatButtonModule,
		TestPageModule,
		AppRoutingModule,
		AssignTestPageModule,
		HeaderModule,
		FooterModule,
		TranslateModule,
		MenuModule,
		MenuModule,
		CreatePageModule
	],
	providers: [],
	bootstrap: []
})
export class MainPageModule {}
