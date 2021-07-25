import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { SpeakingComponent } from './speaking.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	imports: [CommonModule, MatButtonModule, TranslateModule],
	declarations: [SpeakingComponent],
	exports: [SpeakingComponent]
})
export class SpeakingModule {}
