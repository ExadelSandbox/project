import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { MatButtonModule } from '@angular/material/button';
import { TestNavBtnComponent } from './test-nav-btn.component';

@NgModule({
	declarations: [TestNavBtnComponent],
	imports: [BrowserModule, MatButtonModule],
	providers: [],
	exports: [TestNavBtnComponent]
})
export class TestNavBtnModule {}
