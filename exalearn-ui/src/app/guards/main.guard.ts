import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { from, Observable, of } from 'rxjs';
import { Injectable } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { UserService } from '../services/user.service';
import { map } from 'rxjs/operators';

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
			return from(this.userService.getUser()).pipe(
				map((status) => {
					if (!!status) {
						return true;
					}
					this.router.navigate(['/main']);
					return false;
				})
			);
		}
		return true;
	}
}
