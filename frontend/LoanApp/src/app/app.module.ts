import { LoanTableComponent } from "./loans/loan-view/loan-table/loan-table.component";
import { LoanService } from "./services/loan.service";
import { LoanViewComponent } from "./loans/loan-view/loan-view.component";
import { LoanCardComponent } from "./loans/loan-view/loan-card/loan-card.component";
import { ToolbarComponent } from "./header-toolbar/toolbar/toolbar.component";
import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { MatCardModule } from "@angular/material/card";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";
import { MatIconModule } from "@angular/material/icon";
import { MatButtonModule } from "@angular/material/button";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatSnackBarModule } from "@angular/material/snack-bar";
import { MatSelectModule } from "@angular/material/select";
import { MatDialogModule } from "@angular/material/dialog";
import { MatStepperModule } from "@angular/material/stepper";
import { MatRadioModule } from "@angular/material/radio";
import { MatTooltipModule } from "@angular/material/tooltip";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { MatSliderModule } from "@angular/material/slider";
import { HttpClientModule } from "@angular/common/http";
import { MatCurrencyFormatModule } from "mat-currency-format";
import { MatTableModule } from "@angular/material/table";

@NgModule({
  declarations: [
    AppComponent,
    ToolbarComponent,
    LoanCardComponent,
    LoanViewComponent,
    LoanTableComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule,
    MatToolbarModule,
    MatSelectModule,
    MatToolbarModule,
    MatSnackBarModule,
    MatDialogModule,
    MatStepperModule,
    MatRadioModule,
    MatTooltipModule,
    FormsModule,
    ReactiveFormsModule,
    MatSliderModule,
    HttpClientModule,
    MatCurrencyFormatModule,
    MatTableModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
