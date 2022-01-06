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
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, int>
    {

        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteProductCommandHandler(IProductRepository _productrepository, IUnitOfWork unitOfWork)
        {
            productRepository = _productrepository;
            _unitOfWork = unitOfWork;
        }
        public async   Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var item = new Product();
            item.ProductId = request.ProductId;
            productRepository.Delete(item);
            _unitOfWork.save();
            return  item.ProductId;
            
        }
    }
}
