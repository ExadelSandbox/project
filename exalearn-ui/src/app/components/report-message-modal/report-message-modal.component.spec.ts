import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportMessageModalComponent } from './report-message-modal.component';

describe('ReportMessageModalComponent', () => {
	let component: ReportMessageModalComponent;
	let fixture: ComponentFixture<ReportMessageModalComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [ReportMessageModalComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(ReportMessageModalComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
