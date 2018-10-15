import * as Raven from 'raven-js';
import {Injector, ErrorHandler , ApplicationRef, Injectable, Inject, NgZone , isDevMode } from "@angular/core";
import { ToastrService } from 'ngx-toastr';


@Injectable()
export class AppErrorHandler extends ErrorHandler {

    constructor( private inj : Injector , private ngZone : NgZone  ) 
    {
        super();
    }

    handleError(error: any): void {
        if (!isDevMode())
            Raven.captureException(error.originalError || error);
        else
            throw error ;
           this.ngZone.run( () => {

            let toastr = this.inj.get(ToastrService);
        
            toastr.error("An unexpected error","error",{
            timeOut : 3000 ,
            closeButton : true 
          });
          super.handleError(error); 

           } );
                 
    };
}