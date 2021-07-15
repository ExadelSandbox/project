import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { TestPageModule } from '../test-page/test-page.module';

import { MainPageComponent } from './main-page.component';
import { HeaderComponent } from '../../components/header/header.component';
import { FooterComponent } from '../../components/footer/footer.component';

@NgModule({
	declarations: [MainPageComponent, HeaderComponent, FooterComponent],
	imports: [BrowserModule, MatButtonModule, TestPageModule, AppRoutingModule],
	providers: [],
	bootstrap: []
})
export class MainPageModule {}
