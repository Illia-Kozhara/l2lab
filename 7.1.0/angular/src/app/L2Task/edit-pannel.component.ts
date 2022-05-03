import { Component } from "../../../node_modules/@angular/core/core";


@Component({
    selector: 'edit-pannel-component',
    template: `
    <input #nMSG
      (keyup.enter)="sendMSG(nMSG.value)"
      (blur)="sendMSG(nMSG.value); nMSG.value='' ">

    <button type="button" (click)="sendMSG(nMSG.value)">Send</button>`
})
export class EditPannelComponent {
    messages = ['First message'];
    sendMSG(nMSG: string) {
        if (nMSG) {
            this.messages.push(nMSG);
        }
    }
}
