using Application.AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IProductService<Product>
    {
        Task Add(Product product);
        Task<int> Delete(int id);
        Task<int> Update(Product entity);
        Task<IEnumerable<Product>> GetAll();
    }
}
