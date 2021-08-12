import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckQuestionComponent } from './check-question.component';

describe('CheckQuestionComponent', () => {
	let component: CheckQuestionComponent;
	let fixture: ComponentFixture<CheckQuestionComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckQuestionComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckQuestionComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
