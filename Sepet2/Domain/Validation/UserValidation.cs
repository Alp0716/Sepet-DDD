using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(user => user.UserId).GreaterThan(0);
            RuleFor(user => user.UserName).MaximumLength(15);
            RuleFor(user => user.LastName).MaximumLength(10);



        }
    }
}
