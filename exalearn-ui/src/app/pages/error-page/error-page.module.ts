import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';
import { ErrorPageComponent } from './error-page.component';
import { FooterModule } from '../../components/footer/footer.module';

@NgModule({
	declarations: [ErrorPageComponent],
	imports: [CommonModule, MatButtonModule, TranslateModule, FooterModule]
})
export class ErrorPageModule {}
