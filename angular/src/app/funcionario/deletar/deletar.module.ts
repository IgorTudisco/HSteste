import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { DeletarRoutingModule } from './deletar-routing.module';
import { DeletarComponent } from './deletar.component';

@NgModule({
  declarations: [DeletarComponent],
  imports: [SharedModule, DeletarRoutingModule],
})
export class DeletarModule { }
