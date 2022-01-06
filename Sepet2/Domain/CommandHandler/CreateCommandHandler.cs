using Domain.Command;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.CommandHandler
{
    public class CreateCommandHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        public CreateCommandHandler(IUserRepository _userrepository, IUnitOfWork _unitOfWork)
        {
            userRepository = _userrepository;
            unitOfWork = _unitOfWork;
        }
        public Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var result = new User();
            result.UserId = request.UserId;
            result.UserName = request.UserName;
            result.Password = request.Password;
            result.LastName = request.LastName;
            userRepository.Add(result);
            unitOfWork.save();
            return Task.FromResult(result);

        }
    }
}
