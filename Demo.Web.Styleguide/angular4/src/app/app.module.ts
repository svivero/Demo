import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

//
// Components
//
import { SgHeaderComponent }  from './styleguide/header/sg-header.component';

//
// Services
//

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ SgHeaderComponent ],
  bootstrap:    [ SgHeaderComponent ],
})
export class AppModule { }
