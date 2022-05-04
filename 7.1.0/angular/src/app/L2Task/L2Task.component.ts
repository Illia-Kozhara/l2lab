import {
    ChangeDetectionStrategy, Component,
    EventEmitter, Injector, Output
} from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import {
    CreateUserDto, SendMessageDto, UserServiceProxy
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
        this.mMsgDTO.msgText = this.uMSG;

    }

    constructor(
        injector: Injector,
        public _userService: UserServiceProxy) {
        super(injector);
    }

    sendMSGEvent() {

        //try to post
        this._userService.sendMSG(this.mMsgDTO).subscribe(
            () => {
                this.notify.info(this.l('SavedSuccessfully'));
            },
            () => {
                this.getstartedEV = "false";
            }
        );

        this.uMSG = this.mMsgDTO.msgText;
        return this.uMSG;
    }
}
