import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
	selector: 'app-finish-test-button',
	templateUrl: './finish-test-button.component.html',
	styleUrls: ['./finish-test-button.component.scss']
})
export class FinishTestButtonComponent {
	constructor(private router: Router) {}

	// async postTest(url = '', data = {}) {
	// 	const response = await fetch(url, {
	// 		method: 'POST',
	// 		mode: 'cors',
	// 		cache: 'no-cache',
	// 		credentials: 'same-origin',
	// 		headers: {
	// 			'Content-Type': 'application/json'
	// 		},
	// 		redirect: 'follow',
	// 		referrerPolicy: 'no-referrer',
	// 		body: JSON.stringify(data)
	// 	});
	// 	return await response.json();
	// }

	// void this.postTest('/api/testAnswer', { answer: 42 }).then((data) => {
	// 	console.log(data);
	// });

	// 	url = '/api/testAnswer';
	// 	data = { test: 'test' };
	//
	//   try {
	//   const response = await fetch(this.url, {
	//     method: 'POST',
	//     body: JSON.stringify(this.data),
	//     headers: {
	//       'Content-Type': 'application/json'
	//     }
	//   });
	//   const json = await response.json();
	//   console.log('Успех:', JSON.stringify(json));
	// } catch (error) {
	//   console.error('Ошибка:', error);
	// }

	public async submitTest() {
		void (await this.router.navigate(['/main']));
	}
}
