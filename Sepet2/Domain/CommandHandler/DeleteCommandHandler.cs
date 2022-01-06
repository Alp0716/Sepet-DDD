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
    public class DeleteCommandHandler : IRequestHandler<DeleteUserCommand, int>
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        public DeleteCommandHandler(IUserRepository _userrepository, IUnitOfWork _unitOfWork)
        {
            userRepository = _userrepository;
            unitOfWork = _unitOfWork;
        }
        public Task<int> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User();
            user.UserId = request.UserId;
            userRepository.Delete(user);
            unitOfWork.save();
            return Task.FromResult(user.UserId);
        }
    }
}
