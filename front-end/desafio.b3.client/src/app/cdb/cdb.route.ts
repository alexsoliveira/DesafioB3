import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CdbAppComponent } from './cdb.app.component';
import { CdbCalculoComponent } from './calculo/cdb-calculo.component';

const cdbRouterConfig: Routes = [
    {
        path: '', component: CdbAppComponent,
        children: [
            { path: 'calculo', component: CdbCalculoComponent },            
        ]
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(cdbRouterConfig)
    ],
    exports: [RouterModule]
})
export class CdbRoutingModule { }