import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ViewTestModalComponent } from './view-test-modal.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [ViewTestModalComponent],
	imports: [BrowserModule, TranslateModule]
})
export class ViewTestModalModule {}
