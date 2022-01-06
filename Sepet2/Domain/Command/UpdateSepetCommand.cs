using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command
{
    public class UpdateSepetCommand:IRequest<int>
    {

        public int SepetId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Stock { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public double price { get; set; }
    }
}
