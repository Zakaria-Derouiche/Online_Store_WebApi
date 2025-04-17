
using Data.Models;


namespace Business.Services
{
    public interface IOrderItemsService
    {
        IEnumerable<OrderItems> GetAllOrderItems();
        OrderItems GetOrderItemsById(int id);
        void CreateOrderItems(OrderItems orderItems);
        void UpdateOrderItems(OrderItems orderItems);
        void DeleteOrderItems(int id);
    }
}
