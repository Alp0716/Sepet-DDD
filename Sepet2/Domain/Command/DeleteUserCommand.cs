using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Command
{
   public  class DeleteUserCommand:IRequest<int>
    {
        public int UserId { get; set; }
        
    }
}
