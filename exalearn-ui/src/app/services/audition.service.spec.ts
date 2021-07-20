import { TestBed } from '@angular/core/testing';

import { AuditionService } from './audition.service';

describe('AuditionService', () => {
	let service: AuditionService;

	beforeEach(() => {
		TestBed.configureTestingModule({});
		service = TestBed.inject(AuditionService);
	});

	it('should be created', () => {
		expect(service).toBeTruthy();
	});
});
