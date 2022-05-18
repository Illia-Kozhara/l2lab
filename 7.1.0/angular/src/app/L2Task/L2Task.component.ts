import {
    ChangeDetectionStrategy, Component,
    Injector,
    Input
} from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { Root, L2MessagesServiceProxy, MessageDto, SendMessageDto, Result } from '@shared/service-proxies/service-proxies';
import { Observable } from 'rxjs';


@Component({
    templateUrl: './L2Task.component.html',
    animations: [appModuleAnimation()],
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class L2TaskComponent extends AppComponentBase {
    
    getstartedEV: string;
    uMSG: string;
    //observable: Observable<Result[]>;
    //tested
    mMsgDTO = new SendMessageDto();
    chatHistory: Result[] = [];

    constructor(
        injector: Injector,
        public _l2MessageService: L2MessagesServiceProxy) {
        super(injector);
        
    }

    ngOnInit(): void {
        this.getMessageHistory();
        this.uMSG = 'This is jus a basic!';
        /*this.observable = Observable.create(observer => {
            observer.next(this.chatHistory);
    });
    this.observable.subscribe(chatHistory => this.chatHistory = chatHistory);*/
    }

    sendMSGEvent() {
        const m = new SendMessageDto();
        m.initString(this.uMSG);
        //try to post
        this._l2MessageService.sendMSG(m).subscribe(
            () => {
                this.notify.info(this.l('SavedSuccessfully'));
            },
            () => {
                this.getstartedEV = "false";
            }
        );
        this.getMessageHistory();
        return this.uMSG;
    }

    getMessageHistory(){
        this._l2MessageService.getAllMSG().subscribe(root => {
            this.chatHistory = root.result; 
        });
    }
    //ToDo>> remove this solution
    updateHistory() {
        this.getMessageHistory();
    }
}
