import { Component, Inject } from '@angular/core';
import { Tickets } from './Tickets';
import { HelpDeskService } from '../help-desk.service';

@Component({
  selector: 'app-tickets',
  templateUrl: './tickets.component.html',
  providers: [HelpDeskService]
})
/** Tickets component*/
export class TicketsComponent {
  //array of Tickets
  public tickets: Tickets[] = [];
    

  constructor(private HelpDeskService: HelpDeskService) {
      
    this.tickets = [];
    }
    
  }
