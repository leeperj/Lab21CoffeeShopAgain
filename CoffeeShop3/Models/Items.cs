using System;
using System.Collections.Generic;

namespace CoffeeShop3.Models
{
    public partial class Items
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}
