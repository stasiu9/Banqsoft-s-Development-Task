using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class LoanRepository:RepositoryBase<Loan>,ILoanRepository
    {
        public LoanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public IEnumerable<Loan> GetAllLoans(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.LoanType)
            .ToList();

        public Loan GetLoan(Guid loanId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(loanId), trackChanges).SingleOrDefault();
    }
}
