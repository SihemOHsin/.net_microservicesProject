using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Data
{
    public class ProductsApiContext : DbContext
    {
        public ProductsApiContext (DbContextOptions<ProductsApiContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsApi.Models.Product> Product { get; set; } = default!;
    }
}
