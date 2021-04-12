using System;
using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace LoanAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Loan, LoanDto>();
                
        }
    }
}
