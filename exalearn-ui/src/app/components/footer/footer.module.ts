import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';
import { FooterComponent } from './footer.component';

@NgModule({
	declarations: [FooterComponent],
	imports: [CommonModule, TranslateModule],
	providers: [],
	exports: [FooterComponent]
})
export class FooterModule {}
