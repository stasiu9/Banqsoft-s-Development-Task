using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanAPI.Controllers
{
    [Route("api/loans")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly ILoanService _loanService;

        public LoansController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper,ILoanService loanService)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _loanService = loanService;
        }

        [HttpGet]
        public IActionResult GetLoans()
        {
            try
            {
                var loans = _repository.Loan.GetAllLoans(trackChanges: false);
                var loansDto = _mapper.Map<IEnumerable<LoanDto>>(loans);
                return Ok(loansDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetLoans)} action {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetLoan(Guid id)
        {
            var loan = _repository.Loan.GetLoan(id, trackChanges: false);
            if (loan == null)
            {
                _logger.LogInfo($"Loan with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var loanDto = _mapper.Map<LoanDto>(loan);
                return Ok(loanDto);
            }
        }

        [HttpPost]
        public IActionResult CalculateLoan(LoanToCalculate loanToCalculate)
        {
            var monthlyLoans=_loanService.CalculateLoan(loanToCalculate);
            return Ok(monthlyLoans);
        }
    }
}