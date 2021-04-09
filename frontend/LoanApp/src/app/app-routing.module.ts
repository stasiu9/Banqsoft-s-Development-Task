import { LoanViewComponent } from "./loans/loan-view/loan-view.component";
import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

const routes: Routes = [
  {
    path: "",
    redirectTo: "/loans",
    pathMatch: "full",
  },
  {
    path: "loans",
    component: LoanViewComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
