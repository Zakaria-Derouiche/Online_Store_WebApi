using System;
using System.Collections.Generic;
using System.Linq;


namespace Data.Models
{
    public class Product
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Category category { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedOn { get; set; }

        public List<OrderItems> ProductOrderItems { get; set; }

    }
}
