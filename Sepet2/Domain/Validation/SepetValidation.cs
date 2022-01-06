using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation
{
   public  class SepetValidation:AbstractValidator<Sepet>
    {
        public SepetValidation()
        {
            RuleFor(s => s.SepetId).GreaterThan(0);
            RuleFor(s => s.ProductName).MaximumLength(25);
          
        }
    }
}
