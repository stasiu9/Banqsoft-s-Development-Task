using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class LoanConfiguration: IEntityTypeConfiguration<Loan>
    {
       
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasData
            (
                new Loan
                {
                    Id = new Guid("96a7ebc6-65b2-4c7a-96bc-4daac6a5b237"),
                    LoanType="Housing loan",
                    InterestRate=3.5

                },
                new Loan
                {
                    Id = new Guid("b6014483-03ac-4829-8b0b-ad2627542df4"),
                    LoanType = "Car loan",
                    InterestRate = 5.3

                }
             ); 
        }
    }
}
