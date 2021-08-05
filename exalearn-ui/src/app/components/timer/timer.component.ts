import { Component, OnInit, Input, OnChanges, SimpleChanges, ViewChild, ElementRef, OnDestroy } from '@angular/core';
import { TimerService } from '../../services/timer.service';
import { AfterViewInit } from '@angular/core';
import { Subscription } from 'rxjs';

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss'],
	providers: [TimerService]
})
export class TimerComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {
	@Input() startTimerOnInit = false;
	@Input() speakingTimerStarted = false;
	@Input() label = '';
	@Input() mode = '';
	@Input() resetSpeakingTimer = false;

	@ViewChild('timer', { read: ElementRef })
	timerContainer: ElementRef;

	constructor(private timerService: TimerService) {}

	public testTimerSubscriber: Subscription;
	public minutes: string;
	public seconds: string;

	ngOnInit(): void {
		if (this.startTimerOnInit) {
			this.timerService.startTotalDurationTimer();
		}
		this.testTimerSubscribe();
	}

	ngAfterViewInit(): void {
		this.timerContainer.nativeElement.classList.add(this.mode);
	}

	ngOnChanges(changes: SimpleChanges) {
		this.timerService.resetSpeakingTimer();
		if (this.speakingTimerStarted) {
			this.timerService.startSpeakingTimer();
		} else {
			this.timerService.pauseSpeakingTimer();
		}
	}

	ngOnDestroy(): void {
		this.stopTimerSubscribe();
		this.timerService.pauseTimer();
	}

	testTimerSubscribe(): void {
		this.testTimerSubscriber = this.timerService.testTimerObservable.subscribe((value) => {
			if (value != undefined) {
				this.minutes = value.mins;
				this.seconds = value.secs;
			}
		});
	}

	stopTimerSubscribe(): void {
		this.testTimerSubscriber.unsubscribe();
	}
}
