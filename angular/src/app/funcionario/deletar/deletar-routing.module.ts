import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DeletarComponent } from './deletar.component';

const routes: Routes = [
  {
    path: '',
    component: DeletarComponent,
    pathMatch: 'full',
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DeletarRoutingModule { }
