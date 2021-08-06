import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { UserService } from '../services/user.service';

@Injectable({ providedIn: 'root' })
export class MainGuard implements CanActivate {
	constructor(private auth: AuthService, private router: Router, private userService: UserService) {}

	canActivate(
		route: ActivatedRouteSnapshot,
		state: RouterStateSnapshot
	): Observable<boolean> | Promise<boolean> | boolean {
		if (!this.auth.isAuthenticated()) {
			void this.router.navigate(['/login']);
		}
		if (!this.userService.currentUser) {
			this.userService.getUser().then((status) => {
				!status && void this.router.navigate(['/login']);
			});
		}
		return true;
	}
}
