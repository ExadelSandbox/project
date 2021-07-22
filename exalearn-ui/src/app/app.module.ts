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
import { LoginPageLayoutComponent } from './layouts/login-page-layout/login-page-layout.component';
import { MainPageLayoutComponent } from './layouts/main-page-layout/main-page-layout.component';
import { HeaderModule } from './components/header/header.module';
import { FooterModule } from './components/footer/footer.module';
import { AllHistoryPageModule } from './pages/all-history-page/all-history-page.module';
import { MyAssignedTestsPageModule } from './pages/my-assigned-tests-page/my-assigned-tests-page.module';

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
	declarations: [AppComponent, LoginPageLayoutComponent, MainPageLayoutComponent],
	imports: [
		BrowserModule,
		AppRoutingModule,
		HttpClientModule,
		TranslateModule.forRoot(translateRootConfig),
		MainPageModule,
		LoginPageModule,
		HeaderModule,
		FooterModule,
		MyHistoryPageModule,
		AllHistoryPageModule,
		MyAssignedTestsPageModule
	],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
