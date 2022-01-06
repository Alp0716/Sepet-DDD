using Application.AutoMapper;
using AutoMapper;
using Domain.Command;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ProductService : BaseService, IProductService<Product>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository productRepository;
        public ProductService(IMediator mediator, IMapper mapper, IUnitOfWork unitOfWork, IProductRepository _productrepository)
        {
            _mediator = mediator;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            productRepository = _productrepository;

        }

        public Task Add(Product product)
        {
            var item = _mapper.Map<CreateProductCommand>(product);
            _mediator.Send(item);
            _unitOfWork.save();
            return Task.FromResult(true);
        }

        public   Task<int> Delete(int Id)
        {
            var result = _mediator.Send(new DeleteProductCommand() {ProductId=Id });
            return Task.FromResult(result.Result);
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            var item = productRepository.GetAll();
            return item;
        }

        public  Task<int> Update(Product entity)
        {            
            var updateProductCommand = _mapper.Map<UpdateProductCommand>(entity);
            var item2 = _mediator.Send(updateProductCommand);   
            return Task.FromResult(item2.Result);
        }

    }
}
