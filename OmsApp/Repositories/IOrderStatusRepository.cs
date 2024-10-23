using OmsApp.Entities;

namespace OmsApp.Repositories;

public interface IOrderStatusRepository
{
    Task<OrderStatus> AddOrderStatusAsync(OrderStatus orderStatus);
    Task<Order> GetOrderByIdAsync(int orderId);
}