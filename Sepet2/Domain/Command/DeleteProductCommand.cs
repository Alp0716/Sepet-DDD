using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command
{
    public class DeleteProductCommand:IRequest<int>
    {
        public int ProductId { get; set; }
    }
}
