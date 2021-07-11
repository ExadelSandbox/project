import { Component } from '@angular/core';

@Component({
  selector: 'header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.less']
})
export class HeaderComponent {
  isAppInitialized = true;
  isAuthorized = true;

  public profile() {
    console.log('profile_click');
  }

  public logout() {
    console.log('logout_click');
  }
}
