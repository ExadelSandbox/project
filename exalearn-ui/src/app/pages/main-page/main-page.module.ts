import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';

import { MainPageComponent } from './main-page.component';
import { HeaderComponent } from '../../components/header/header.component';
import { FooterComponent } from '../../components/footer/footer.component';

@NgModule({
	declarations: [MainPageComponent, HeaderComponent, FooterComponent],
	imports: [BrowserModule, MatButtonModule],
	providers: [],
	bootstrap: []
})
export class MainPageModule {}
