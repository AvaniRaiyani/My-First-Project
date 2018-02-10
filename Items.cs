using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanisHerbalSalon.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
