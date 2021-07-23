import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { TestPageModule } from '../test-page/test-page.module';
import { MainPageComponent } from './main-page.component';
import { AssignTestPageModule } from '../assign-test-page/assign-test-page.module';
import { FooterModule } from '../../components/footer/footer.module';
import { HeaderModule } from '../../components/header/header.module';
import { TranslateModule } from '@ngx-translate/core';
import { AllHistoryPageModule } from '../all-history-page/all-history-page.module';
import { CreatePageModule } from '../create-page/create-page.module';
import { StartContentModule } from '../../components/start-content/start-content.module';
import { MyHistoryPageModule } from '../my-history-page/my-history-page.module';
import { MyAssignedTestsPageModule } from '../my-assigned-tests-page/my-assigned-tests-page.module';
import { TestsAssignedByUserModule } from '../tests-assigned-by-user/tests-assigned-by-user.module';

@NgModule({
	declarations: [MainPageComponent],
	imports: [
		BrowserModule,
		AllHistoryPageModule,
		MatButtonModule,
		TestPageModule,
		AppRoutingModule,
		AssignTestPageModule,
		HeaderModule,
		FooterModule,
		TranslateModule,
		CreatePageModule,
		StartContentModule,
		MyHistoryPageModule,
		AllHistoryPageModule,
		MyAssignedTestsPageModule,
		TestsAssignedByUserModule
	],
	providers: [],
	exports: [MainPageComponent],
	bootstrap: []
})
export class MainPageModule {}
