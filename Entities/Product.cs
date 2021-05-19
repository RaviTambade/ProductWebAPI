
using System.Text.Json.Serialization;
namespace ProductWebAPI.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
         
        public double UnitPrice { get; set; }

    }
}