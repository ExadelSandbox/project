import { NgModule } from '@angular/core';
import { CheckTestComponent } from './check-test.component';
import { MatDialogModule } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [CheckTestComponent],
	imports: [
		MatDialogModule,
		FormsModule,
		MatFormFieldModule,
		MatButtonModule,
		MatSelectModule,
		BrowserModule,
		TranslateModule
	],
	exports: [CheckTestComponent]
})
export class CheckTestModule {}
