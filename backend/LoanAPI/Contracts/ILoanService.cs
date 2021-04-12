using System;
using System.Collections.Generic;
using Entities.DataTransferObjects;

namespace Contracts
{
    public interface ILoanService
    {
        List<MonthlyPayment> CalculateLoan(LoanToCalculate loanToCalculate);
    }
}
