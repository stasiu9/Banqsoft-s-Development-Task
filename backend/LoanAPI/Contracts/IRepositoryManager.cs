using System;
namespace Contracts
{
    public interface IRepositoryManager
    {
        ILoanRepository Loan { get; }
        void Save();
    }
}
