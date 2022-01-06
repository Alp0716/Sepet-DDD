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
    public class UpdateSepetCommandHandler : IRequestHandler<UpdateSepetCommand, int>
    {
        private readonly IBaseRepository<Sepet> baseRepository;
        private readonly IUnitOfWork ofWork;
        public UpdateSepetCommandHandler(IBaseRepository<Sepet> @base, IUnitOfWork  unit)
        {
            baseRepository = @base;
            ofWork = unit;
        }
        public Task<int> Handle(UpdateSepetCommand request, CancellationToken cancellationToken)
        {
            var result = new Sepet();
            result.SepetId = request.SepetId;
            result.LastName = request.LastName;
            result.UserName = request.UserName;
            result.ProductName = request.ProductName;
            result.ProductId = request.ProductId;
            result.price = request.price;
            result.UserId = request.UserId; ;
            result.Stock = request.Stock;
            baseRepository.Update(result);
            ofWork.save();
            return Task.FromResult(result.SepetId);
        }
    }
}
