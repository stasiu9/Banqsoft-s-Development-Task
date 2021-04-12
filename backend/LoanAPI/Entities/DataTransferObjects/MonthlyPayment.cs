using System;
namespace Entities.DataTransferObjects
{
    public class MonthlyPayment
    {
        public decimal Month { get; set; }
        public double StartingBalance { get; set; }
        public double Repayment { get; set; }
        public double InterestPaid { get; set; }
        public double PrincipalPaid { get; set; }
        public double NewBalance { get; set; }
    }
}
