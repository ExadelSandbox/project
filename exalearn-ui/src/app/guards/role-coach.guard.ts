import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { UserService } from '../services/user.service';
import { RoleNames } from '../enums/enums';

@Injectable({
	providedIn: 'root'
})
export class RoleCoachGuard implements CanActivate {
	constructor(private userService: UserService, private router: Router) {}

	canActivate(
		route: ActivatedRouteSnapshot,
		state: RouterStateSnapshot
	): Observable<boolean> | Promise<boolean> | boolean {
		if (`${this.userService.currentUser?.role.toLocaleLowerCase()}` !== RoleNames.Coach) {
			void this.router.navigate(['/main']);
		}
		return true;
	}
}
