using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface ISepetService
    {
        void Add(Sepet sepet);
        void Delete(int id);
        void update(Sepet sepet);
        Task<IEnumerable<Sepet>> GetAll();
    }
}
