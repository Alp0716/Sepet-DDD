using Application.Service;
using Domain.Models;
using Domain.Validation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService<User> userService;
        
        public UserController(IUserService<User> _userService)
        {
            userService = _userService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            var result = userService.GetAll();
            return Ok(result); 
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            try
            {
                UserValidation validations = new UserValidation();
                ValidationResult validation = validations.Validate(user);
                if (!validation.IsValid)
                    return BadRequest(validation.Errors);
                var result = userService.UserAdd(user);
                return Ok(result);
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }
            //userService.UserAdd(user);
            //return Ok();
        }
        [HttpPut]
        public IActionResult Update(User user)
        {
            userService.UserUpdate(user);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int UserId)
        {
            userService.UserDelete(UserId);
            return Ok();
        }
    }
}
