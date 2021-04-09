import { LoanService } from "./../../services/loan.service";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-loan-view",
  templateUrl: "./loan-view.component.html",
  styleUrls: ["./loan-view.component.css"],
})
export class LoanViewComponent implements OnInit {
  typesOfLoan: [];
  constructor(private loanService: LoanService) {}

  ngOnInit() {}

  private getTypesOfLoan() {
    return this.loanService.getTypesOfLoan().subscribe((resp) => {
      console.log(resp);
      // this.typesOfLoan = resp;
    });
  }
}
