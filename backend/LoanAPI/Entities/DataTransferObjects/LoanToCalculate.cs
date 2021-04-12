using System;
namespace Entities.DataTransferObjects
{
    public class LoanToCalculate
    {
       public string LoanType { get; set; }
       public string LoanAmount { get; set; }
       public decimal Years { get; set; }
       public double InterestRate { get; set; }
    }
}
