using System.Collections.Generic;
using System.Linq;
using ProductWebAPI.Entities;

namespace ProductWebAPI.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<Product> WithoutPasswords(this IEnumerable<Product> products) 
        {
            if (products == null) return null;

            return products.Select(x => x.WithoutPassword());
        }

        public static Product WithoutPassword(this Product product) 
        {
            if (product == null) return null;

           // product.Password = null;
            return product;
        }
    }
}