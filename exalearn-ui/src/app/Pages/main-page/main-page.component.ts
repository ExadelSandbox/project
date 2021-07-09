import { Component, OnInit } from '@angular/core';
import {RedirectBtn} from "../../Interfaces/Interfaces";

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.less']
})
export class MainPageComponent implements OnInit {
  btns: RedirectBtn[] = [
    {name: "tests history", url: "/history-page"},
    {name: "pass test", url: "/test-page"},
    {name: "assigned tests", url: "/assigned-tests-page"},
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
