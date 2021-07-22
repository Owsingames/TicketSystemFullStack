import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';



@Injectable({
  providedIn: 'root'
})








export class HelpDeskService {
  constructor(private http: HttpClient) {

  }
  //Not super confident with this subscribe method really
  controller: string = '';
  baseURL: string = `https://localhost:44314/api/${this.controller}`



  //getTickets(): any {
  //  this.controller = 'Tickets'
  //  return this.http.get<Ticket>(this.baseURL);
  //}

  //getBookmarks(): any {
  //  this.controller = 'Bookmarks'
  //  return this.http.get<Bookmark>(this.baseURL);
  //}
}
