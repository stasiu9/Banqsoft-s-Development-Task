import { MonthlyPayment } from "./../../../models/MonthlyPayment";
import { Component, Input, OnInit } from "@angular/core";

@Component({
  selector: "app-loan-table",
  templateUrl: "./loan-table.component.html",
  styleUrls: ["./loan-table.component.css"],
})
export class LoanTableComponent implements OnInit {
  @Input() monthlyPayments: MonthlyPayment[];
  displayedColumns: string[] = [
    "month",
    "startingBalance",
    "repayment",
    "interestPaid",
    "principalPaid",
    "newBalance",
  ];
  constructor() {}

  ngOnInit() {}
}
