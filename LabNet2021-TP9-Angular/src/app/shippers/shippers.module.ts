import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { ShippersRoutingModule } from './shippers-routing.module';
import { ShippersComponent } from './components/shippers/shippers.component';

@NgModule({
  declarations: [
    ShippersComponent
  ],
  imports: [
    CommonModule,
    ShippersRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ]
})
export class ShippersModule { }
