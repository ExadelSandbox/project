import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckEssayComponent } from './check-essay.component';

describe('CheckEssayComponent', () => {
	let component: CheckEssayComponent;
	let fixture: ComponentFixture<CheckEssayComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckEssayComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckEssayComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
