import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MainPageModule } from './pages/main-page/main-page.module';
import { MyHistoryPageModule } from './pages/my-history-page/my-history-page.module';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageModule } from './pages/login-page/login-page.module';
import { MissingTranslationHandler, TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { MissingTranslationService } from './services/missing-translation.service';
import { AllHistoryPageModule } from './pages/all-history-page/all-history-page.module';

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
		MyHistoryPageModule,
		AllHistoryPageModule
	],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
