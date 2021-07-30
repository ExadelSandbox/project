import { CanDeactivate } from '@angular/router';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';

export interface ComponentCanDeactivate {
	canDeactivate: () => boolean | Observable<boolean>;
}

@Injectable({ providedIn: 'root' })
export class LeaveGuard implements CanDeactivate<ComponentCanDeactivate> {
	canDeactivate(component: ComponentCanDeactivate): Observable<boolean> | boolean {
		return component.canDeactivate ? component.canDeactivate() : true;
	}
}
