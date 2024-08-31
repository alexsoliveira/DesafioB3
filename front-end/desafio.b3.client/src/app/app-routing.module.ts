import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CdbAppComponent } from './cdb/cdb.app.component';
import { CdbCalculoComponent } from './cdb/calculo/cdb-calculo.component';

const routes : Routes = [
    { path: '', redirectTo: '/calculo', pathMatch: 'full' },
    { path: 'calculo', component: CdbCalculoComponent },
    {
        path: 'calculo',
        loadChildren: () => import('./cdb/cdb.module')
            .then(m => m.CdbModule)
    },     
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }