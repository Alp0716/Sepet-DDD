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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork unitOfWork;
        public UpdateProductCommandHandler(IProductRepository _productrepository,IUnitOfWork _unitOfWork)
        {
            productRepository = _productrepository;
            unitOfWork = _unitOfWork;
        }
        public  Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var result = new Product()
            {
                ProductId = request.ProductId,
                ProductName = request.ProductName,
                Stock = request.Stock,
                CreateTime = request.CreateTime
            };
            productRepository.Update(result);
            unitOfWork.save();
            return Task.FromResult(result.ProductId);
        }
    }
}
