import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css'],
})
export class ServersComponent {
  serverId: number = 1001;
  serverStatus: string = 'offline';

  addNewServer: boolean = false;
  serverCreated: string = 'Not yet';

  serverName : string = '';

  serverList = ['SQL','Oracle'];


  // onServerNameEntry(event:Event)
  // {
  //   console.log(event);
  //   this.serverName = (<HTMLInputElement>event.target).value;
  // }

  constructor() {
    setTimeout(() => {
      this.addNewServer = true;
    }, 5000);
  }

  onServerCreation() {
    this.serverCreated = 'Created';
    this.serverList.push(this.serverName);
  }

  getServerId() {
    return this.serverId;
  }
  getServerStatus() {
    return this.serverStatus;
  }
}
