using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
  public   class SepetDto
    {
        public int Id { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
