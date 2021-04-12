using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface ILoanRepository
    {
        IEnumerable<Loan> GetAllLoans(bool trackChanges);
        Loan GetLoan(Guid loanId, bool trackChanges);
    }
}
