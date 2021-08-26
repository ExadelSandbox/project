import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportQuestionModalComponent } from './report-question-modal.component';

describe('ReportQuestionModalComponent', () => {
	let component: ReportQuestionModalComponent;
	let fixture: ComponentFixture<ReportQuestionModalComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [ReportQuestionModalComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(ReportQuestionModalComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
