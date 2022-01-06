using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command
{
   public  class UpdateProductCommand:IRequest<int>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Stock { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
