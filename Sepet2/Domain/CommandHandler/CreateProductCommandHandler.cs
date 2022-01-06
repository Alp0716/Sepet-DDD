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
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork unitOfWork;
        public CreateProductCommandHandler(IProductRepository _productRepository, IUnitOfWork _unitOfWork)
        {
            productRepository = _productRepository;
            unitOfWork = _unitOfWork;
        }
        public Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var item = new Product();
            item.ProductId = request.ProductId;
            item.ProductName = request.ProductName;
            item.Stock = request.Stock;
            productRepository.Add(item);
            unitOfWork.save();
            return Task.FromResult(item);
        }
    }
}
