import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuComponent } from './menu.component';
import { TranslateModule } from '@ngx-translate/core';
import { MatButtonModule } from '@angular/material/button';
import { RouterModule } from '@angular/router';

@NgModule({
	declarations: [MenuComponent],
	imports: [CommonModule, TranslateModule, MatButtonModule, RouterModule],
	providers: [],
	exports: [MenuComponent]
})
export class MenuModule {}
