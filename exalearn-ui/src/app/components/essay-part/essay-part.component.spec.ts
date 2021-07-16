import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EssayPartComponent } from './essay-part.component';

describe('EssayPartComponent', () => {
	let component: EssayPartComponent;
	let fixture: ComponentFixture<EssayPartComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [EssayPartComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(EssayPartComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
