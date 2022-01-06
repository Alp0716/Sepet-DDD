using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Command
{
   public  class CreateUserCommand:IRequest<User>
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }


    }
}
