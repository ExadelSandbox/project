import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { UserAuth } from '../../interfaces/interfaces';

@Component({
	selector: 'app-login-page',
	templateUrl: './login-page.component.html',
	styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent {
	constructor(public auth: AuthService) {}

	emailFormControl = new FormControl('', [Validators.required, Validators.email]);
	passwordFormControl = new FormControl('', [Validators.required]);

	submit() {
		const user: UserAuth = {
			username: this.emailFormControl.value,
			password: this.passwordFormControl.value
		};

		this.auth.login(user);
	}
}
