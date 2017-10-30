import { NgModule }      from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Registers critical application service providers, it also includes common directives like NgIf
import { BrowserModule } from '@angular/platform-browser';

//
// Components
//
import { SgHeaderComponent }  from './styleguide/components/header/sg-header.component';
import { SgButtonsComponent }  from './styleguide/components/elements/sg-buttons.component';
import { HomeComponent } from './styleguide/components/home/sg-home.component';
import { AppComponent } from './styleguide/components/app.component';

export const ROUTES: Routes = [
  { path: '', pathMatch: 'full', component: HomeComponent },
  { path: 'elements/buttons', component: SgButtonsComponent }
];

//
// Services
//

@NgModule({
  imports:      [
    BrowserModule,

    // Define root config for the main module
    RouterModule.forRoot(ROUTES)
  ],
  declarations: [
    SgHeaderComponent,
    SgButtonsComponent,
    HomeComponent,
    AppComponent
  ],

  // Load these components on app start up
  bootstrap:    [
    SgHeaderComponent,
    AppComponent
  ],
})
export class AppModule { }
