import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ListarRoutingModule } from './listar-routing.module';
import { ListarComponent } from './listar.component';

@NgModule({
  declarations: [ListarComponent],
  imports: [SharedModule, ListarRoutingModule],
})
export class ListarModule { }
