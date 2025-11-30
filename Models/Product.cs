using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Models
{
    public class Product
    {
        public Product(string name, string category, float price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Category = category;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price {  get; set; }
    }
}
