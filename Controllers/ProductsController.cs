using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ProductWebAPI.Services;
using ProductWebAPI.Entities;
using System;

namespace ProductWebAPI.Controllers
{  
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
    
        [HttpGet]
        public IActionResult GetAll()
        {
            var products =  _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           var product =  _productService.GetById(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}