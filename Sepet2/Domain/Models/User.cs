using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        [Display(Name = "User Id")]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
