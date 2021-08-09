import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';

@Component({
	selector: 'app-start-content',
	templateUrl: './start-content.component.html',
	styleUrls: ['./start-content.component.scss']
})
export class StartContentComponent implements OnInit {
	currentUser: any;
	fullName: string;

	constructor(public userService: UserService) {}

	ngOnInit() {
		this.currentUser = this.userService.currentUser;
		this.fullName = `${this.currentUser.firstName} ${this.currentUser.lastName}`;
	}
}
