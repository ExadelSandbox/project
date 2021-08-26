import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ViewTestModalComponent } from './view-test-modal.component';
import { TranslateModule } from '@ngx-translate/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

@NgModule({
	declarations: [ViewTestModalComponent],
	imports: [BrowserModule, TranslateModule, MatButtonModule, MatIconModule]
})
export class ViewTestModalModule {}
