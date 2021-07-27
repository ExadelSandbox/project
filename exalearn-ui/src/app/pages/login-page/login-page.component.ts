import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';

import { UserAuth } from '../../interfaces/interfaces';

@Component({
	selector: 'app-login-page',
	templateUrl: './login-page.component.html',
	styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent {
	constructor(public auth: AuthService) {}

	emailFormControl = new FormControl('adminexa@mailnesia.com', [Validators.required, Validators.email]); //clear formState before prod release
	passwordFormControl = new FormControl('_Test1234', [Validators.required]); //clear formState before prod release

	submit() {
		const user: UserAuth = {
			username: this.emailFormControl.value,
			password: this.passwordFormControl.value
		};

		this.auth.login(user);
	}
}
