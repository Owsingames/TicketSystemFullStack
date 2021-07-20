import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
    selector: 'app-user',
    templateUrl: './user.component.html',
    styleUrls: ['./user.component.css']
})
/** User component*/
export class UserComponent {
    //array of users
    public users: User[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl:string) {
    http.get<Users[]>(baseUrl + 'user').subscribe(result => {
      this.users = result;
      }, error => console.error(error));
    }
}
