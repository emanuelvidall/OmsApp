using OmsApp.Dtos;
using OmsApp.Entities;

namespace OmsApp.Services;

public interface IOrderStatusService
{
    Task<OrderStatus> CreateOrderStatusAsync(OrderStatusCreateDto orderStatusDto);
}