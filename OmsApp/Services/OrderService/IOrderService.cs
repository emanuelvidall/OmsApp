using OmsApp.Dtos;

namespace OmsApp.Services.OrderService;

public interface IOrderService
{
    Task<IEnumerable<OrderDto>> GetAllOrdersAsync();
    Task<OrderDto> CreateOrderAsync(CreateOrderDto createOrderDto);
}