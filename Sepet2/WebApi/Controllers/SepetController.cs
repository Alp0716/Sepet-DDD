using Application.Service;
using Domain.Models;
using Domain.Validation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class SepetController : ControllerBase
    {
        private readonly ISepetService sepetService;
        private readonly ILogger<SepetController> logger;
        public SepetController(ISepetService sepet, ILogger<SepetController> _logger)
        {
            sepetService = sepet;
            logger = _logger;
        }
        [HttpPost]
        public IActionResult Add(Sepet sepet)
        {
            try
            {
                SepetValidation validations = new SepetValidation();
                ValidationResult validation = validations.Validate(sepet);
                if (!validation.IsValid)
                    return BadRequest(validation.Errors);
                 sepetService.Add(sepet);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            //sepetService.Add(sepet);
            //return Ok();
        }
        [HttpDelete]
        public  IActionResult Delete(int id)
        {
            sepetService.Delete(id);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = sepetService.GetAll();
            logger.LogInformation("getall metotu çalıştı");
            return Ok(result);
        }
        [HttpPut]
        public IActionResult Update(Sepet sepet)
        {
            sepetService.update(sepet);
            return Ok();
        }
    }
}
