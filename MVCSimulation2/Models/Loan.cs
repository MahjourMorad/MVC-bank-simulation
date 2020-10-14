using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSimulation2.Models
{
    public class Loan
    {
        public double loanAmount { get; set; }
        public double loanTerm { get; set; }
        public double interestRate { get; set; }
        public double result { get; set; }
    }
}
