import { CONSTS } from "./../consts";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root",
})
export class LoanService {
  private url: string;
  constructor(private http: HttpClient, private consts: CONSTS) {
    this.url = consts.BASE_URL;
  }

  public getTypesOfLoan() {
    return this.http.get(this.url);
  }
}
