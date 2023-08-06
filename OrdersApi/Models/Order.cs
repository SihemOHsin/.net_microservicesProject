using System.ComponentModel.DataAnnotations;

namespace OrdersApi.Models
{
    public class Order
    {
        [Key]
        public int Orderid { get; set; }
        public DateTime OrderDate { get; }
        public String? CustomerName { get; set; }
        public int Prodid { get; set; }
    }
}
