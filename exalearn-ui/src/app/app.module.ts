import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { MainPageComponent } from './pages/main-page/main-page.component';
import { MatButtonModule } from '@angular/material/button';
import { HeaderComponent } from "./header/header.component";


@NgModule({
  declarations: [
    AppComponent,
    MainPageComponent,
    HeaderComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatButtonModule,
  ],
  providers: [],
  bootstrap: [
    AppComponent,
    HeaderComponent,
  ]
})
export class AppModule {
}
