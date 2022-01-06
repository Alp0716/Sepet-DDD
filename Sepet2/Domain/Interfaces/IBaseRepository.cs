using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
   public  interface IBaseRepository<T> where T:class
    {
        void Delete(T id);
        void Update(T entity);
        void Add(T entity);
         Task<IEnumerable<T>> GetAll();
    }
}
