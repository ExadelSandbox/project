import { Component, OnInit } from '@angular/core';
import { ReportMessageModalComponent } from '../report-message-modal/report-message-modal.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
	selector: 'app-check-essay',
	templateUrl: './check-essay.component.html',
	styleUrls: ['./check-essay.component.scss']
})
export class CheckEssayComponent implements OnInit {
	textEssay = 'Test';
	themeEssay = 'My Hobby';
	reportComment = 'asd';
	fillingEssay = 512;
	essayMark = 1;

	constructor(public dialog: MatDialog) {}

	ngOnInit(): void {}

	openReportComment(comment: string): void {
		this.dialog.open(ReportMessageModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				modalHeader: 'REPORT_MESSAGE_MODAL.USER_REPORTED_THIS_TOPIC',
				comment
			}
		});
	}

	setMark(mark: number): void {
		this.essayMark = mark;
	}
}
