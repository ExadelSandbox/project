import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { MainPageComponent } from './pages/main-page/main-page.component';
import { MatButtonModule } from '@angular/material/button';
import { FooterComponent } from './components/footer/footer.component';

@NgModule({
	declarations: [AppComponent, MainPageComponent, FooterComponent],
	imports: [BrowserModule, AppRoutingModule, MatButtonModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
