using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation
{
    public class ProductValidation:AbstractValidator<Product>
    {
        //public ProductValidation()
        //{
        //    RuleFor(product => product.ProductId).GreaterThan(0);
        //    RuleFor(product => product.ProductName).MaximumLength(20);
        //    RuleFor(product => product.Stock).InclusiveBetween(40, 500);

        //}
    }
}
