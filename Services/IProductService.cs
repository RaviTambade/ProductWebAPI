using System.Collections.Generic;
using ProductWebAPI.Entities;

namespace ProductWebAPI.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }
}