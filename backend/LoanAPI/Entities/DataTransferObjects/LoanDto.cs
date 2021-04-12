using System;
namespace Entities.DataTransferObjects
{
    public class LoanDto
    {
       public Guid Id { get; set; }
       public string LoanType { get; set; }
       public double InterestRate { get; set; }
    }
}
