using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command
{
    public class CreateProductCommand : IRequest<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Stock { get; set; }
       
    }
}
