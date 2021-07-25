import { NgModule } from '@angular/core';
import { LoginPageComponent } from './login-page.component';
import { BrowserModule } from '@angular/platform-browser';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TranslateModule } from '@ngx-translate/core';
import { FooterModule } from '../../components/footer/footer.module';

@NgModule({
	declarations: [LoginPageComponent],
	imports: [
		BrowserModule,
		MatCardModule,
		MatFormFieldModule,
		MatInputModule,
		ReactiveFormsModule,
		MatButtonModule,
		BrowserAnimationsModule,
		TranslateModule,
		FooterModule
	],
	providers: [],
	bootstrap: []
})
export class LoginPageModule {}
