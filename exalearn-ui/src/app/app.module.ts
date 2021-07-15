import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MainPageModule } from './pages/main-page/main-page.module';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { EssayPartComponent } from './components/essay-part/essay-part.component';
import { LoginPageModule } from './pages/login-page/login-page.module';

@NgModule({
	declarations: [AppComponent, EssayPartComponent],
	imports: [BrowserModule, AppRoutingModule, MainPageModule, LoginPageModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
