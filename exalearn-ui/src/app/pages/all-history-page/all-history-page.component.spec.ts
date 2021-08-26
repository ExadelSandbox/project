import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllHistoryPageComponent } from './all-history-page.component';

describe('AllHistoryPageComponent', () => {
	let component: AllHistoryPageComponent;
	let fixture: ComponentFixture<AllHistoryPageComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [AllHistoryPageComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(AllHistoryPageComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
