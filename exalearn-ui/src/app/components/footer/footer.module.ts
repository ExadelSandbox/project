import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';
import { FooterComponent } from './footer.component';
import { MatSelectModule } from '@angular/material/select';
import { ToasterModule } from 'angular2-toaster';

@NgModule({
	declarations: [FooterComponent],
	imports: [CommonModule, TranslateModule, MatSelectModule, ToasterModule],
	providers: [],
	exports: [FooterComponent]
})
export class FooterModule {}
