import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { AuthService } from '../auth.service';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
	constructor(private authService: AuthService, private router: Router) {}

	canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | boolean {
		this.authService.isAuthenticated().then((isAuth) => {
			if (isAuth) {
				this.router.navigateByUrl('/main');
			}
			// else {
			//   this.router.navigate(['/'], {
			//     queryParams: {
			//       auth: false
			//     }
			//   })
			// }
		});
		return true;
	}
}
