using Application.AutoMapper;
using Application.Service;
using Domain.Interfaces;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductService<Product> productService;
       
        public ProductController(IProductService<Product>  _productService)
        {
            productService = _productService;
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            try
            {
                ProductValidation validations = new ProductValidation();
                ValidationResult result = validations.Validate(product);
                if (!result.IsValid)
                    return BadRequest(result.Errors);
                var result2 = productService.Add(product);
                return Ok(result2);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            //productService.Add(product);
            //return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            productService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Product product)
        {
             productService.Update(product);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           var item = productService.GetAll();
            return Ok(item);
        }
    }
}
