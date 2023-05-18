import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CatsTableComponent } from './cats/cats-table/cats-table.component';

const routes: Routes = [
  {path: '', component: CatsTableComponent},
  {path: '**', redirectTo: ''}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
