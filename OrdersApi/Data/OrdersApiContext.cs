using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrdersApi.Models;

namespace OrdersApi.Data
{
    public class OrdersApiContext : DbContext
    {
        public OrdersApiContext (DbContextOptions<OrdersApiContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrdersApi.Models.Order> Order { get; set; } = default!;
    }
}
