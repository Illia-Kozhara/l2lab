import { HttpHeaders, HttpParams } from '@angular/common/http';
import {
    ChangeDetectionStrategy, Component,
    EventEmitter, Injector, Output
} from '@angular/core';
import { HttpClient } from '@aspnet/signalr';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import {
    CreateUserDto, L2LabMessageServiceProxy, SendMessageDto, UserServiceProxy
} from '@shared/service-proxies/service-proxies';
import { forEach as _forEach } from 'lodash-es';


@Component({
    templateUrl: './L2Task.component.html',
    animations: [appModuleAnimation()],
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class L2TaskComponent extends AppComponentBase {

    getstartedEV: string;
    uMSG: string;

    //tested
    mMsgDTO = new SendMessageDto();

    ngOnInit(): void {
        this.uMSG = 'This is jus a basic!';
        //init data
        

    }

    constructor(
        injector: Injector,
        public _userService: UserServiceProxy) {
        super(injector);
    }

    sendMSGEvent() {
        //this.mMsgDTO.msgText = this.uMSG;
        const m = new SendMessageDto();
        //m.init(this.mMsgDTO);
        m.initString(this.uMSG);
        //try to post
        this._userService.sendMSG(m).subscribe(
            () => {
                this.notify.info(this.l('SavedSuccessfully'));
            },
            () => {
                this.getstartedEV = "false";
            }
        );
        return this.uMSG;
    }
}
