using System;
using System.Collections.Generic;
using Contracts;
using Entities.DataTransferObjects;

namespace LoanAPI.Utility
{
    public class LoanService:ILoanService
    {
        public List<MonthlyPayment> CalculateLoan(LoanToCalculate loanToCalculate)
        {
            double repayment = 0;
            List<MonthlyPayment> monthlyPayments = new List<MonthlyPayment>();
            double loanBalance = Convert.ToDouble(loanToCalculate.LoanAmount);
            double numerator = (Convert.ToDouble(loanToCalculate.LoanAmount) * (loanToCalculate.InterestRate / 100));
            double denominator = 12 * (1 - (Math.Pow((12 / (12 + (loanToCalculate.InterestRate / 100))), (Convert.ToDouble(loanToCalculate.Years)) * 12)));
            repayment = Math.Round((numerator / denominator),2);
            for (int i=0;i<loanToCalculate.Years*12;i++)
            {
                MonthlyPayment monthlyPaymentTemp = new MonthlyPayment();
                monthlyPaymentTemp.Month = i + 1;
                if (i == 0)
                {
                    monthlyPaymentTemp.StartingBalance = loanBalance;
                }
                else
                {
                    
                    monthlyPaymentTemp.StartingBalance =Math.Round(monthlyPayments[monthlyPayments.Count - 1].NewBalance,2);
                }
                monthlyPaymentTemp.Repayment = repayment;
                double interestPaid = 0;
                interestPaid = ((loanToCalculate.InterestRate / 100) / 12) * monthlyPaymentTemp.StartingBalance;
                monthlyPaymentTemp.InterestPaid = Math.Round(interestPaid,2);
                monthlyPaymentTemp.PrincipalPaid = Math.Round(repayment - interestPaid,2);
                monthlyPaymentTemp.NewBalance = Math.Round(monthlyPaymentTemp.StartingBalance - monthlyPaymentTemp.PrincipalPaid,2);
                loanBalance = monthlyPaymentTemp.NewBalance;
                monthlyPayments.Add(monthlyPaymentTemp);
            }
            monthlyPayments[monthlyPayments.Count-1].NewBalance=Math.Round(monthlyPayments[monthlyPayments.Count - 1].NewBalance,0);
            return monthlyPayments;
        }

    }
}
