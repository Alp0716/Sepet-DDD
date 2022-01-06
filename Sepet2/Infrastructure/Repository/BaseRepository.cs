using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SepetDb _context;

        public BaseRepository(SepetDb context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);

        }

        public void Delete(T id)
        {

            _context.Remove(id);

        }


        public async Task<IEnumerable<T>> GetAll()
        {
            var item = _context.Set<T>().ToList();

            return item;
        }

        public void Update(T entity)
        {
            _context.Update(entity);

        }

    }
}
