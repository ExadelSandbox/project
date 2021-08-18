import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckSpeakingComponent } from './check-speaking.component';

describe('CheckSpeakingComponent', () => {
	let component: CheckSpeakingComponent;
	let fixture: ComponentFixture<CheckSpeakingComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckSpeakingComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckSpeakingComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
