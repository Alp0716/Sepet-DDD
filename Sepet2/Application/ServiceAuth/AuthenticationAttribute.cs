using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceAuth
{
    public class AuthenticationAttribute : ActionFilterAttribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userRepository = context.HttpContext.RequestServices.GetService(typeof(IUserRepository)) as UserRepository;
            var a = userRepository.GetAll().Result.ToList();
            var getAuthParams = context.HttpContext.Request.Headers.FirstOrDefault(x => x.Key.Equals("Authorization")).Value;
            var outBasic = getAuthParams.ToString().Split(' ')[1];
            var base64ByteArr = Convert.FromBase64String(outBasic);
            var userNamePass = Encoding.UTF8.GetString(base64ByteArr);
            var splited = userNamePass.Split(':');
            for (int i = 0; i < a.Count; i++)
            {
                if (splited[0] == a[i].UserName && splited[1] == a[i].Password) return;
            }
            context.Result = new StatusCodeResult(401);
        }
    }
}
