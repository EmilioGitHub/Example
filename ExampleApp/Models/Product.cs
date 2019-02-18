using System;

namespace ExampleApp.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }
        public Product()
        {
            this.Name = "";
            this.Description = "";
            this.Price = default(uint);
        }
        public Product(string name, string desc, uint price)
        {
            this.Name = name;
            this.Description = desc;
            this.Price = price;
        }
        public abstract void Info();
    }
}