import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { MainPageComponent } from './main-page.component';
import { MatButtonModule } from '@angular/material/button';
import { HeaderComponent } from '../../header/header.component';

@NgModule({
	declarations: [MainPageComponent, HeaderComponent],
	imports: [BrowserModule, MatButtonModule],
	providers: [],
	bootstrap: []
})
export class MainPageModule {}
