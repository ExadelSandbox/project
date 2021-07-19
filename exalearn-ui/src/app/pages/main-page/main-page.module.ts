import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { TestPageModule } from '../test-page/test-page.module';

import { MainPageComponent } from './main-page.component';
import { HeaderComponent } from '../../components/header/header.component';
import { FooterComponent } from '../../components/footer/footer.component';
import { AssignTestPageModule } from '../assign-test-page/assign-test-page.module';
import { AllHistoryPageModule } from '../all-history-page/all-history-page.module';

@NgModule({
	declarations: [MainPageComponent, HeaderComponent, FooterComponent],
	imports: [
		BrowserModule,
		MatButtonModule,
		TestPageModule,
		AppRoutingModule,
		AssignTestPageModule,
		AllHistoryPageModule
	],
	providers: [],
	bootstrap: []
})
export class MainPageModule {}
