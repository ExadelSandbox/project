import { NgModule } from '@angular/core';
import { LoginPageComponent } from './login-page.component';
import { BrowserModule } from '@angular/platform-browser';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
	declarations: [LoginPageComponent],
	imports: [
		BrowserModule,
		MatCardModule,
		MatFormFieldModule,
		MatInputModule,
		ReactiveFormsModule,
		MatButtonModule,
		BrowserAnimationsModule
	]
})
export class LoginPageModule {}
