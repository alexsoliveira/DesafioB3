import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes : Routes = [
    { path: '', redirectTo: '/cdb', pathMatch: 'full'}, 
    {
        path: 'cdb',
        loadChildren: () => import('./cdb/cdb.module')
            .then(m => m.CdbModule)
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }