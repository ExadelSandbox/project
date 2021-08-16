import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';

import { CheckNavBtnComponent } from './check-nav-btn.component';

@NgModule({
	declarations: [CheckNavBtnComponent],
	imports: [BrowserModule, MatButtonModule],
	exports: [CheckNavBtnComponent]
})
export class CheckNavBtnModule {}
