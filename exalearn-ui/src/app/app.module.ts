import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MainPageModule } from './pages/main-page/main-page.module';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { MainPageComponent } from './pages/main-page/main-page.component';
import { MatButtonModule } from '@angular/material/button';
import { HeaderComponent } from './components/header/header.component';
import { TestPageComponent } from './pages/test-page/test-page.component';
import { TimerComponent } from './components/timer/timer.component';
import { TestPageModule } from './pages/test-page/test-page.module';

@NgModule({
	declarations: [AppComponent],
	imports: [BrowserModule, AppRoutingModule, MainPageModule],
	declarations: [AppComponent, MainPageComponent, HeaderComponent, TestPageComponent, TimerComponent],
	imports: [BrowserModule, AppRoutingModule, MatButtonModule, BrowserAnimationsModule, TestPageModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
