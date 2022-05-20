import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '../../../shared/app-component-base';
import { L2MessagesServiceProxy, Result } from '../../../shared/service-proxies/service-proxies';

@Component({
  selector: 'app-message-history-component',
  templateUrl: './message-history-component.component.html',
  styleUrls: ['./message-history-component.component.css']
})
export class MessageHistoryComponent extends AppComponentBase implements OnInit {

    uMSG: string;
    history: Result[] = [];


    refreshGrid: boolean;
    //@Input() refreshGrid: boolean = false;

    constructor(
        injector: Injector,
        public _l2MessageService: L2MessagesServiceProxy) {
        super(injector);
        this.update();
    }
    ngOnInit(): void {
        this.update();
        this.uMSG = 'This is jus a basic!';
    }

    getMessageHistory() {
        this._l2MessageService.getAllMSG().subscribe(root => {
            this.history = root.result;
        });
    }
    getHistory() {
        
    }
    //ToDo>> remove this solution
    update() {
        this.getMessageHistory();
    }

    refreshList($event: any) {
        this.refreshGrid = true;
        console.log('refresh event ', $event);
    }

    ngOnChanges() {
        if (this.refreshGrid) {
            this.getMessageHistory();
        }
    }

    ngOnDestroy() {
        
    }

}
