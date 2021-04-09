import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";

@Injectable({
  providedIn: "root",
})
export class CONSTS {
  constructor() {}
  BASE_URL = environment.baseUrl;
}
