import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MenuModule } from '../menu/menu.module';
import { FormsModule } from '@angular/forms';
import { MainContentComponent } from './main-content.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [MainContentComponent],
	imports: [CommonModule, RouterModule, MenuModule, FormsModule, TranslateModule],
	providers: [],
	exports: [MainContentComponent]
})
export class MainContentModule {}
