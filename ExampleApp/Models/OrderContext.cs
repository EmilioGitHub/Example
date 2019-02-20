using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleApp.Models
{
    public class OrderContext:DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}