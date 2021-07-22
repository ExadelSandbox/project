import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../header/header.component';
import { TranslateModule } from '@ngx-translate/core';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
	declarations: [HeaderComponent],
	imports: [CommonModule, TranslateModule, MatButtonModule],
	providers: [],
	exports: [HeaderComponent]
})
export class HeaderModule {}
