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

namespace Domain.CommandHandler
{
    public class UpdateCommandHandler : IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        public UpdateCommandHandler(IUserRepository _userrepository, IUnitOfWork _unitOfWork)
        {
            userRepository = _userrepository;
            unitOfWork = _unitOfWork;
        }
        public Task<int> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var result = new User();
            result.UserId = request.UserId;
            result.UserName = request.UserName;
            result.LastName = request.LastName;
            result.Password = request.Password;
            userRepository.Update(result);
            unitOfWork.save();
            return Task.FromResult(result.UserId);
        }
    }
}

