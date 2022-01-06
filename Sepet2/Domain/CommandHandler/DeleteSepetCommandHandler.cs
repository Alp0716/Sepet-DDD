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
    public class DeleteSepetCommandHandler : IRequestHandler<DeleteSepetCommand, int>
    {
        private readonly IBaseRepository<Sepet> baseRepository;
        private readonly IUnitOfWork unitOfWork;
        public DeleteSepetCommandHandler(IBaseRepository<Sepet> _baseRepository,IUnitOfWork _unitOfWork)
        {
            baseRepository = _baseRepository;
            unitOfWork = _unitOfWork;
        }
        public Task<int> Handle(DeleteSepetCommand request, CancellationToken cancellationToken)
        {
            var item = new Sepet()
            {
                SepetId = request.SepetId
            };
            baseRepository.Delete(item);
            unitOfWork.save();
            return Task.FromResult(item.SepetId);
        }
    }
}
