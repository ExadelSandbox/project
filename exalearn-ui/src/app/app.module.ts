import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MainPageModule } from './pages/main-page/main-page.module';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { EssayPartComponent } from './components/essay-part/essay-part.component';

@NgModule({
	declarations: [AppComponent, EssayPartComponent],
	imports: [BrowserModule, AppRoutingModule, MainPageModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
