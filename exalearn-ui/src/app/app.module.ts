import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AngularFireModule } from '@angular/fire';
import { AngularFireStorageModule } from '@angular/fire/storage';
import { MainPageModule } from './pages/main-page/main-page.module';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageModule } from './pages/login-page/login-page.module';
import { MissingTranslationHandler, TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { MissingTranslationService } from './services/missing-translation.service';
import { environment } from '../environments/environment.prod';
import { CookieService } from 'ngx-cookie-service';
import { ToasterModule } from 'angular2-toaster';
import { ApiService } from './services/api.service';
import { ErrorPageComponent } from './pages/error-page/error-page.component';
import { MatButtonModule } from '@angular/material/button';
import { ErrorPageModule } from './pages/error-page/error-page.module';
import { FooterModule } from './components/footer/footer.module';

export function HttpLoaderFactory(http: HttpClient): TranslateLoader {
	return new TranslateHttpLoader(http, './assets/locale/', '.json');
}

const translateRootConfig = {
	loader: {
		provide: TranslateLoader,
		useFactory: HttpLoaderFactory,
		deps: [HttpClient]
	},
	missingTranslationHandler: { provide: MissingTranslationHandler, useClass: MissingTranslationService },
	useDefaultLang: false
};

@NgModule({
	declarations: [AppComponent, ErrorPageComponent],
	imports: [
		BrowserModule,
		AppRoutingModule,
		HttpClientModule,
		TranslateModule.forRoot(translateRootConfig),
		MainPageModule,
		LoginPageModule,
		ErrorPageModule,
		AngularFireStorageModule,
		AngularFireModule.initializeApp(environment.firebase),
		ToasterModule.forRoot(),
		MatButtonModule,
		FooterModule
	],
	providers: [CookieService, ApiService],
	exports: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
