import { Component, OnInit } from '@angular/core';
import { RolesService } from '../../services/roles.service';
import { Assignment, RedirectBtn } from '../../interfaces/interfaces';
import { MatDialog } from '@angular/material/dialog';
import { StartTestModalComponent } from '../start-test-modal/start-test-modal.component';
import { UserService } from '../../services/user.service';

@Component({
	selector: 'app-menu',
	templateUrl: './menu.component.html',
	styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
	btns: readonly RedirectBtn[] = [];

	constructor(private roleService: RolesService, public dialog: MatDialog, private userService: UserService) {}

	ngOnInit(): void {
		this.btns = this.roleService.getBtns(`${this.userService.currentUser?.role.toLocaleLowerCase()}`);
	}

	openStartTestDialog(): void {
		this.dialog.open(StartTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: ''
		});
	}
}
