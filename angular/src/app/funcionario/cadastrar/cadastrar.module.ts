import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CadastrarRoutingModule } from './cadastrar-routing.module';
import { CadastrarComponent } from './cadastrar.component';

@NgModule({
  declarations: [CadastrarComponent],
  imports: [SharedModule, CadastrarRoutingModule],
})
export class CadastrarModule { }
