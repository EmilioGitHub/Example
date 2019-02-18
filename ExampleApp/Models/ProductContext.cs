using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;

namespace ExampleApp.Models
{
    public class ProductContext:DbContext
    {
        public DbSet<Product>Products { get; set; }
        public DbSet<Purchase> Purchases{ get;set; }
    }
}