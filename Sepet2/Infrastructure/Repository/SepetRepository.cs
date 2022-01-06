using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
   public  class SepetRepository:BaseRepository<Sepet>,ISepetRepository
    {
        public SepetRepository(SepetDb context):base(context)
        {
        }
    }
}
