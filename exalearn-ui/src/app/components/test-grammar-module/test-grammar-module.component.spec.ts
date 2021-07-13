import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestGrammarModuleComponent } from './test-grammar-module.component';

describe('TestGrammarModuleComponent', () => {
	let component: TestGrammarModuleComponent;
	let fixture: ComponentFixture<TestGrammarModuleComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [TestGrammarModuleComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(TestGrammarModuleComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
