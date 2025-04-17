using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IOrderItemsRepository
    {

        IEnumerable<OrderItems> GetAll();

        OrderItems  GetById(int id);

        void Add(OrderItems orderItems);

        void Update(OrderItems orderItems);

        void Delete(int id);
    }
}
