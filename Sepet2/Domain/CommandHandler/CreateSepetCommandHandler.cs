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
    public class CreateSepetCommandHandler : IRequestHandler<CreateSepetCommand, Sepet>
    {
        private readonly IBaseRepository<Sepet> baseRepository;
        private readonly IUnitOfWork unitOfWork;
        public CreateSepetCommandHandler(IBaseRepository<Sepet> _baseRepository,IUnitOfWork unitOf)
        {
            baseRepository = _baseRepository;
            unitOfWork = unitOf;
        }
        public Task<Sepet> Handle(CreateSepetCommand request, CancellationToken cancellationToken)
        {
            var result = new Sepet();
            result.SepetId = request.SepetId;
            result.price= request.price;
            result.ProductName = request.ProductName;
            result.UserName = request.UserName;
            result.UserId = request.UserId;
            result.Stock = request.Stock;
            result.LastName = request.LastName;
            result.ProductId = request.ProductId;
           
            baseRepository.Add(result);
            unitOfWork.save();
            return Task.FromResult(result);
        }
    }
}
