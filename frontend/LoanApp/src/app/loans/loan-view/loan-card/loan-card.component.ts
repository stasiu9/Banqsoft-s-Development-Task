import { Component, Input, OnInit } from "@angular/core";
import { FormGroup } from "@angular/forms";
import { Loan } from "src/app/models/loan";

@Component({
  selector: "app-loan-card",
  templateUrl: "./loan-card.component.html",
  styleUrls: ["./loan-card.component.css"],
})
export class LoanCardComponent implements OnInit {
  @Input() form: FormGroup;
  @Input() typesOfLoan: Loan[];
  constructor() {}
  ngOnInit() {}
}
