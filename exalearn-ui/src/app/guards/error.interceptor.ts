import { Injectable } from '@angular/core';
import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { catchError, tap } from 'rxjs/operators';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
	constructor(private router: Router) {}

	intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
		console.log('request', req);
		return next.handle(req).pipe(
			tap(() => {
				console.log('intercept');
			}),
			catchError((error: HttpErrorResponse) => {
				console.log('Interceptor', error);
				if (error.status === 401) {
					console.log('Interceptor', error);
					this.router.navigate(['/error']);
				}
				return throwError(error);
			})
		);
	}
}
