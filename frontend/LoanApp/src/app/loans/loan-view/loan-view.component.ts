import { MonthlyPayment } from "./../../models/MonthlyPayment";
import { FormGroup } from "@angular/forms";
import { LoanService } from "./../../services/loan.service";
import { Component, OnInit } from "@angular/core";
import { Loan } from "src/app/models/loan";
import { Subscription } from "rxjs";
import { ThrowStmt } from "@angular/compiler";

@Component({
  selector: "app-loan-view",
  templateUrl: "./loan-view.component.html",
  styleUrls: ["./loan-view.component.css"],
})
export class LoanViewComponent implements OnInit {
  loanForm: FormGroup;
  typesOfLoan: Loan[];
  subscriptions: Subscription[] = [];
  monthlyPayments: MonthlyPayment[];
  constructor(private loanService: LoanService) {}

  ngOnInit() {
    // this.subscriptions.push(this.getTypesOfLoan());
    this.createLoanForm();
    this.getTypesOfLoan();
  }

  private createLoanForm() {
    this.loanForm = this.loanService.generateLoanForm();
  }
  private getTypesOfLoan() {
    return this.loanService.getTypesOfLoan().subscribe((resp) => {
      this.typesOfLoan = resp;
    });
  }
  public calculateLoan() {
    const loan = this.typesOfLoan.find(
      (x) => x.loanType == this.loanForm.controls.loanType.value
    );
    this.loanForm.patchValue({
      interestRate: loan.interestRate,
    });
    console.log(this.loanForm.value);
    this.loanService.calculateLoan(this.loanForm.value).subscribe((resp) => {
      this.monthlyPayments = resp;
      console.log(this.monthlyPayments);
    });
  }
}
