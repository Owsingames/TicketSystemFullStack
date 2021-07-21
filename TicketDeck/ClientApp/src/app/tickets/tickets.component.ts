import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HelpDeskService } from '../help-desk.service';
import { Tickets } from './Tickets';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'],

})
/** User component*/
export class TicketsComponent {
  //array of users
  public tickets: Tickets[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Tickets[]>(baseUrl + 'api/users').subscribe(result => {
      this.tickets = result;
      console.log(this.tickets);
    }, error => console.error(error));
  }

  //constructor(private user: HelpDeskService, @Inject('BASE_URL') baseUrl: string) {
  //  this.user.getUser();
  //  console.log(this.user.getUser());
  //}

  //getUser() {
  //  this.user.getUser()
  //    .subscribe((user: any))=> {
  //    this.user=

  //}
}
