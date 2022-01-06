using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IBaseService
    {
        IMapper mapper { get; set; }
        IUnitOfWork unitOf { get; set; }
        
    }
}
