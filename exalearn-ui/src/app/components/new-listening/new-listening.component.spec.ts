import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewListeningComponent } from './new-listening.component';

describe('NewListeningComponent', () => {
	let component: NewListeningComponent;
	let fixture: ComponentFixture<NewListeningComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [NewListeningComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(NewListeningComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
