import { Injectable } from '@angular/core';
import { LeaveTestModalComponent } from '../components/leave-test-modal/leave-test-modal.component';

@Injectable({
	providedIn: 'root'
})
export default class SubmitTestService {}

// export function submitTest(this: any) {
// 	void this.router.navigate(['/main']);
// }
//
// export function closeRefreshPage(this: any, e: any) {
// 	e.preventDefault();
// 	e.returnValue = this.dialog.open(LeaveTestModalComponent, {
// 		width: '50%'
// 	});
// }
