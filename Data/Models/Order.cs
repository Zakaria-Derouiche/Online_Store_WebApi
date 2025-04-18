

using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Data.Models
{
    public class Order
    {
        public int ID { get; set; }
        public User user { get; set; }
        public List<OrderItems> items { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }

    }
}
