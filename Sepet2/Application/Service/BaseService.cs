using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class BaseService : IBaseService
    {
        public IMapper mapper { get ; set ; }
        public IUnitOfWork unitOf { get ; set; }
    }
}
