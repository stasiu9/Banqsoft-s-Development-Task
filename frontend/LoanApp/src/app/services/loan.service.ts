import { MonthlyPayment } from "./../models/MonthlyPayment";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Loan } from "./../models/loan";
import { CONSTS } from "./../consts";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class LoanService {
  private url: string;
  constructor(
    private http: HttpClient,
    private consts: CONSTS,
    private fb: FormBuilder
  ) {
    this.url = consts.LOANS_URL;
  }

  public getTypesOfLoan(): Observable<Loan[]> {
    return this.http.get<Loan[]>(this.url);
  }
  public calculateLoan(loan: any): Observable<MonthlyPayment[]> {
    return this.http.post<MonthlyPayment[]>(this.url, loan);
  }
  public generateLoanForm(): FormGroup {
    const form = this.fb.group({
      loanType: ["", Validators.required],
      loanAmount: ["", Validators.required],
      years: ["", Validators.required],
      interestRate: [""],
    });
    return form;
  }
}
