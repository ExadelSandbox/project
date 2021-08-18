import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { ReportMessageModalComponent } from './report-message-modal.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [ReportMessageModalComponent],
	imports: [BrowserModule, MatButtonModule, TranslateModule]
})
export class ReportMessageModalModule {}
