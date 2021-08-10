import { Component, OnInit } from '@angular/core';
import { RolesService } from '../../services/roles.service';
import { Assignment, RedirectBtn } from '../../interfaces/interfaces';
import { MatDialog } from '@angular/material/dialog';
import { StartTestModalComponent } from '../start-test-modal/start-test-modal.component';
import { AuthService } from '../../services/auth.service';

@Component({
	selector: 'app-menu-droppable',
	templateUrl: './menu-droppable.component.html',
	styleUrls: ['./menu-droppable.component.scss']
})
export class MenuDroppableComponent implements OnInit {
	btns: readonly RedirectBtn[] = [];

	constructor(private roleService: RolesService, public dialog: MatDialog, private authService: AuthService) {}

	ngOnInit(): void {
		this.btns = this.roleService.getBtns('hr');
	}

	openStartTestDialog(): void {
		this.dialog.open(StartTestModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: ''
		});
	}

	logout(): void {
		this.authService.logout();
	}
}
