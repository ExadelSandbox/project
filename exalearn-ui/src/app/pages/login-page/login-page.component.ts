import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { configPopUp } from '../../services/notification.service';
import { UserAuth } from '../../interfaces/interfaces';
import { ToasterConfig } from 'angular2-toaster';

@Component({
	selector: 'app-login-page',
	templateUrl: './login-page.component.html',
	styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent {
	constructor(public auth: AuthService) {
		this.configPopUp = configPopUp;
	}

	emailFormControl = new FormControl('exa@mailnesia.com', [Validators.required, Validators.email]); //TODO: clear formState before prod release
	passwordFormControl = new FormControl('_Test1234', [Validators.required]); //TODO: clear formState before prod release

	public configPopUp: ToasterConfig;

	submit() {
		const user: UserAuth = {
			username: this.emailFormControl.value,
			password: this.passwordFormControl.value
		};

		this.auth.login(user);
	}
}
