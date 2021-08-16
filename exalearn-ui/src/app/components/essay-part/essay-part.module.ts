import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';

import { EssayPartComponent } from './essay-part.component';
import { TranslateModule } from '@ngx-translate/core';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@NgModule({
	declarations: [EssayPartComponent],
	imports: [BrowserModule, MatInputModule, TranslateModule, MatProgressSpinnerModule],
	exports: [EssayPartComponent]
})
export class EssayPartModule {}
