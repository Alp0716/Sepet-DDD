using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private SepetDb _context;
        public UnitOfWork(SepetDb context)
        {
            _context = context;
        }
        
        public void Dispose()
        {
            _context = null;
            
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
