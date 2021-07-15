import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MainPageModule } from './pages/main-page/main-page.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
	declarations: [AppComponent],
	imports: [BrowserModule, AppRoutingModule, MainPageModule, BrowserAnimationsModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
