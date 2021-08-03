import { Component, OnInit } from '@angular/core';
import { RolesService } from '../../services/roles.service';
import { Assignment, RedirectBtn } from '../../interfaces/interfaces';
import { MatDialog } from '@angular/material/dialog';
import { StartTestModalComponent } from '../start-test-modal/start-test-modal.component';
import { AuthService } from '../../services/auth.service';

@Component({
	selector: 'app-menu',
	templateUrl: './menu.component.html',
	styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
	btns: readonly RedirectBtn[] = [];

	constructor(private roleService: RolesService, public dialog: MatDialog, private auth: AuthService) {}

	ngOnInit(): void {
		this.btns = this.roleService.getBtns(localStorage.getItem('roleName') || '');
	}

	openStartTestDialog(): void {
		this.dialog.open(StartTestModalComponent, {
			width: '50%',
			data: ''
		});
	}
}
