import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';

import { EssayPartComponent } from './essay-part.component';

@NgModule({
	declarations: [EssayPartComponent],
	imports: [BrowserModule, MatInputModule],
	exports: [EssayPartComponent]
})
export class EssayPartModule {}
