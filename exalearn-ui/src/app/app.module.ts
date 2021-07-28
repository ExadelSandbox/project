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
import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';

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
	declarations: [AppComponent],
	imports: [
		BrowserModule,
		AppRoutingModule,
		HttpClientModule,
		TranslateModule.forRoot(translateRootConfig),
		MainPageModule,
		LoginPageModule,
		AngularFireStorageModule,
		AngularFireModule.initializeApp(environment.firebase),
		ToasterModule.forRoot(),
		SweetAlert2Module.forRoot()
	],
	providers: [CookieService],
	exports: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
