using Application.AutoMapper;
using AutoMapper;
using Domain.Command;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class SepetService : BaseService, ISepetService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Sepet> baseRepository;
        public SepetService(IMediator mediator, IMapper mapper, IUnitOfWork unitOfWork, IBaseRepository<Sepet> _baseRepository)
        {
            _mediator = mediator;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            baseRepository = _baseRepository;
        }
        public void Add(Sepet sepet)
        {
            var result = _mapper.Map<CreateSepetCommand>(sepet);
            var item1 = _mediator.Send(result);
            _unitOfWork.save(); 
        }
        public void Delete(int id)
        {
            var result = _mediator.Send(new DeleteSepetCommand() { SepetId = id });
            _unitOfWork.save();
        }
        public Task<IEnumerable<Sepet>> GetAll()
        {
            var result = baseRepository.GetAll();
            return result;
        }

        public void update(Sepet sepet)
        {
            var result = _mapper.Map<UpdateSepetCommand>(sepet);
            var result1 = _mediator.Send(result);
        }
    }
}
