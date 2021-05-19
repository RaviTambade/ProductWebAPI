using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using ProductWebAPI.Entities;
using ProductWebAPI.Helpers;

namespace ProductWebAPI.Services
{ 
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>
        { 
            new Product { Id = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 5, Quantity=9198},
            new Product { Id = 2, Title = "Carnation", Description = "Decorative Flower", UnitPrice = 10, Quantity = 6968} ,
            new Product { Id = 3, Title = "Lily", Description = "Beautiful Flower", UnitPrice = 15, Quantity = 8746},
            new Product { Id = 5, Title = "Rose", Description = "Valentine Flower", UnitPrice = 8, Quantity = 4378},
        };


        public IEnumerable<Product> GetAll()
        {
            return _products.WithoutPasswords();
        }

        public Product GetById(int id) 
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return product.WithoutPassword();
        }
    }
}