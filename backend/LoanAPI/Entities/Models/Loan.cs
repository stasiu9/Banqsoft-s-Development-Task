using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Loan
    {
        [Column("LoandId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Loan type is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Loan type is 60 characters.")]
        public string LoanType { get; set; }

        public double InterestRate { get; set; }
    }
}
