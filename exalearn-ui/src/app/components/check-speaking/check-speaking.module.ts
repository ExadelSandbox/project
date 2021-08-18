import { NgModule } from '@angular/core';
import { CheckSpeakingComponent } from './check-speaking.component';
import { BrowserModule } from '@angular/platform-browser';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';
import { MarkModule } from '../mark/mark.module';

@NgModule({
	declarations: [CheckSpeakingComponent],
	imports: [BrowserModule, MatDialogModule, MatButtonModule, TranslateModule, MarkModule],
	exports: [CheckSpeakingComponent]
})
export class CheckSpeakingModule {}
