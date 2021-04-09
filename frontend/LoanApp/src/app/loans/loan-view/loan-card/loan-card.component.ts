import { Component, Input, OnInit } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";

@Component({
  selector: "app-loan-card",
  templateUrl: "./loan-card.component.html",
  styleUrls: ["./loan-card.component.css"],
})
export class LoanCardComponent implements OnInit {
  form: FormGroup;
  @Input() typesOfLoan: [];
  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      loanType: [""],
      loanAmount: [""],
      years: [""],
    });
  }
  formatLabel(value: number) {
    if (value >= 1000) {
      return Math.round(value / 1000) + "k";
    }

    return value;
  }
  ngOnInit() {}

  onSubmit() {}
}
