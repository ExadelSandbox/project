import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckAuditionComponent } from './check-audition.component';

describe('CheckAuditionComponent', () => {
	let component: CheckAuditionComponent;
	let fixture: ComponentFixture<CheckAuditionComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckAuditionComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckAuditionComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
