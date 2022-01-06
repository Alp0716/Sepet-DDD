using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
   public  interface IUserService<User>
    {
        Task UserAdd (User user);
        Task<int> UserDelete(int id);
        Task <int>UserUpdate(User entity);
        Task<IEnumerable<User>> GetAll();
     
    }
}
