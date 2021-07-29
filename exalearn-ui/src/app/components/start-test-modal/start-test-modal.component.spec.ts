import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StartTestModalComponent } from './start-test-modal.component';

describe('StartTestModalComponent', () => {
	let component: StartTestModalComponent;
	let fixture: ComponentFixture<StartTestModalComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [StartTestModalComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(StartTestModalComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
