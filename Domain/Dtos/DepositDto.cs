using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImaPay_BackEnd.Domain.Dtos
{
    public class DepositDto
    {
        public double Amount { get; set; }
        public int AccountId { get; set; }
    }
}