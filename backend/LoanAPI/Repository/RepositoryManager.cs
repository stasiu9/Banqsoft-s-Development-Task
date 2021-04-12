using System;
using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager:IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ILoanRepository _loanRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ILoanRepository Loan
        {
            get
            {
                if (_loanRepository == null)
                    _loanRepository = new LoanRepository(_repositoryContext);

                return _loanRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
