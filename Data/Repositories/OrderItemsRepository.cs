using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class OrderItemsRepository : IOrderItemsRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderItemsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderItems> GetAll() => _context.orderItems;

        public OrderItems GetById(int id) => _context.orderItems.Find(id);

        public void Add(OrderItems orderItems) => _context.orderItems.Add(orderItems);

        public void Update(OrderItems orderItems) => _context.orderItems.Update(orderItems);

        public void Delete(int id)
        {
            var orderItems = GetById(id);
            if (orderItems != null)
            {
                _context.orderItems.Remove(orderItems);
            }
        }
    }
}
