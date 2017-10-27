import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { SgHeaderComponent }  from './styleguide/header/sg-header.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ SgHeaderComponent ],
  bootstrap:    [ SgHeaderComponent ]
})
export class AppModule { }
