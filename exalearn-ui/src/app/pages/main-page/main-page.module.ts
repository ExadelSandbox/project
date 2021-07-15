import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { MatButtonModule } from '@angular/material/button';
import { MainPageComponent } from './main-page.component';

@NgModule({
	declarations: [MainPageComponent],
	imports: [BrowserModule, AppRoutingModule, MatButtonModule],
	providers: [],
	exports: [MainPageComponent]
})
export class MainPageModule {}
