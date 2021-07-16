import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';

@Component({
	selector: 'app-login-page',
	templateUrl: './login-page.component.html',
	styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent implements OnInit {
	emailFormControl = new FormControl('', [Validators.required, Validators.email]);
	passwordFormControl = new FormControl('', [Validators.required]);

	constructor(public auth: AuthService) {}

	ngOnInit(): void {}
}
