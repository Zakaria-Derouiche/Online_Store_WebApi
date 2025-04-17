using Data.Models;
using Data.Repositories;

namespace Business.Services
{
    public class OrderItemsService : IOrderItemsService
    {
        private readonly IOrderItemsRepository _orderItemsRepository;

        public OrderItemsService(IOrderItemsRepository orderItemsRepository)
        {
            _orderItemsRepository = orderItemsRepository;
        }

        public IEnumerable<OrderItems> GetAllOrderItems() => _orderItemsRepository.GetAll();

        public OrderItems GetOrderItemsById(int id) => _orderItemsRepository.GetById(id);

        public void CreateOrderItems(OrderItems orderItems)
        {

            _orderItemsRepository.Add(orderItems);
        }

        public void UpdateOrderItems(OrderItems orderItems)
        {

            _orderItemsRepository.Update(orderItems);
        }

        public void DeleteOrderItems(int id) => _orderItemsRepository.Delete(id);
    }
}
