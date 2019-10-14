using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsMicroservice.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions options)
               : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 1,
                ProductName = "Intel-Keyboard",
                Description = "Intel wirles keyboard",
                Price = 20

            }, new Products
            {
                Id = 2,
                ProductName = "Intel-Mouse",
                Description = "Intel wirles mouse",
                Price = 20
            });
        }
    }
}
