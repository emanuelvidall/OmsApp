using OmsApp.Entities;

namespace OmsApp.Repositories.OrderRepository;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync();
    Task<Order> CreateOrderAsync(Order order);
}