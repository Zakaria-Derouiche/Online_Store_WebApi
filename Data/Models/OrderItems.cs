using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class OrderItems
    {
        public int ID { get; set; }

        public int OrderID { get; set; }

        public Order order { get; set; }

        public int ProductID { get; set; }

        public Product product { get; set; }

        public int Quantity {  get; set; }

    }
}
