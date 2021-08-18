import { NgModule } from '@angular/core';
import { CheckSpeakingComponent } from './check-speaking.component';
import { BrowserModule } from '@angular/platform-browser';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [CheckSpeakingComponent],
	imports: [BrowserModule, MatDialogModule, MatButtonModule, TranslateModule],
	exports: [CheckSpeakingComponent]
})
export class CheckSpeakingModule {}
