import { Component, Injector, ChangeDetectionStrategy } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { CreateUserDto, UserServiceProxy } from '../../shared/service-proxies/service-proxies';

@Component({
  templateUrl: './about.component.html',
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class AboutComponent extends AppComponentBase {

    getstartedE: string;
    //user post data
    user = new CreateUserDto();
    uName = 'L2TaskUser';
    uLName = 'L2TaskUserLastName';
    uPassword = 'L2TaskPass';
    uRole = 'L2TaskRole';
    uEmail = 'L2TaskUser@email.com';

    constructor(injector: Injector, public _userService: UserServiceProxy) {
      super(injector);
  }
    getstartedEvent() {
        this.getstartedE = 'Let`s Go!';
        //init data
        this.user.roleNames = ['admin', this.uRole];
        this.user.name = this.uName;
        this.user.emailAddress = this.uEmail;
        this.user.password = this.uPassword;
        this.user.surname = this.uLName;
        this._userService.create(this.user);

        return this.getstartedE;

    }
}
