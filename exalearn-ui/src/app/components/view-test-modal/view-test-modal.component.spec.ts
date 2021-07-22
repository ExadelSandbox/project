import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewTestModalComponent } from './view-test-modal.component';

describe('ViewTestModalComponent', () => {
	let component: ViewTestModalComponent;
	let fixture: ComponentFixture<ViewTestModalComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [ViewTestModalComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(ViewTestModalComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
