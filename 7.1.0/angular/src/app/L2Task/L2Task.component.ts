import {
    ChangeDetectionStrategy, Component,
    Injector,

    OnInit
} from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { L2MessagesServiceProxy, Result, SendMessageDto } from '@shared/service-proxies/service-proxies';
import { BehaviorSubject, Observable, Subscription } from 'rxjs';
import { finalize } from 'rxjs/operators';


@Component({
    templateUrl: './L2Task.component.html',
    animations: [appModuleAnimation()],
    changeDetection: ChangeDetectionStrategy.OnPush
})

export class L2TaskComponent extends AppComponentBase implements OnInit {
    
    uMSG: string;
    mMsgDTO = new SendMessageDto();
    history: Result[] = [];

    constructor(
        injector: Injector,
        public _l2MessageService: L2MessagesServiceProxy) {
        super(injector);
        //this.update();
    }
    ngOnInit(): void {
        this.update();
        this.uMSG = 'This is jus a basic!';
    }

    sendMSGEvent() {
        const m = new SendMessageDto();
        m.initString(this.uMSG);
        
        this._l2MessageService.sendMSG(m).pipe(
            finalize(() => {
                this.update();
            })
        ).subscribe(
            () => {
                this.notify.info(this.l('SavedSuccessfully'));
            }
        );
        return this.uMSG;
    }

    getMessageHistory() {
        this._l2MessageService.getAllMSG().pipe().subscribe(root => {
            this.history = root.result;
        });
    }
    getHistory() {
        this._l2MessageService.getMessageHistory().subscribe(root => {
            this.history = root.items;
        });
    }
    //ToDo>> modify this solution
    update() {
        this.getMessageHistory();
        //this.getHistory();
    }
}


