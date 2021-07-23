import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MenuModule } from '../menu/menu.module';
import { FormsModule } from '@angular/forms';
import { StartContentComponent } from './start-content.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [StartContentComponent],
	imports: [CommonModule, RouterModule, MenuModule, FormsModule, TranslateModule],
	providers: [],
	exports: [StartContentComponent]
})
export class StartContentModule {}
