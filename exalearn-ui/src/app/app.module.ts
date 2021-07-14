import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MaterialModule } from './modules/material/material.module';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { MainPageComponent } from './pages/main-page/main-page.component';
import { MatButtonModule } from '@angular/material/button';
import { HeaderComponent } from './components/header/header.component';

@NgModule({
	declarations: [AppComponent, MainPageComponent, HeaderComponent],
	imports: [BrowserModule, AppRoutingModule, MatButtonModule, MaterialModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
