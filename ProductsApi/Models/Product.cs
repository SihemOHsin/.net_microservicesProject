using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Models
{
    public class Product

    {
        [Key]
        public int Prodid { get; set; }
        public string Name { get; set; }= String.Empty;
        public int StockQte { get; set; }
        public double Price { get; set; }

    }
}
