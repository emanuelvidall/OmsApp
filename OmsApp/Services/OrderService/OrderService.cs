using OmsApp.Dtos;
using OmsApp.Entities;
using OmsApp.Repositories.OrderRepository;

namespace OmsApp.Services.OrderService;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync()
    {
        var orders = await _orderRepository.GetAllOrdersAsync();
        return orders.Select(o => new OrderDto
        {
            Id = o.Id,
            OrderDate = o.OrderDate,
            TotalAmount = o.TotalAmount,
            ShippingAddress = o.ShippingAddress,
            CustomerId = o.CustomerId,
            Status = o.Status.Status.ToString(),
            PaymentMethodId = o.PaymentMethodId,
            
        }).ToList();
    }

    public async Task<OrderDto> CreateOrderAsync(CreateOrderDto createOrderDto)
    {
        var order = new Order
        {
            OrderDate = createOrderDto.OrderDate,
            TotalAmount = createOrderDto.TotalAmount,
            ShippingAddress = createOrderDto.ShippingAddress,
            CustomerId = createOrderDto.CustomerId,
            PaymentMethodId = createOrderDto.PaymentMethodId,
            OrderItems = createOrderDto.OrderItems.Select(item => new OrderItem
            {
                OrdemItemName = item.OrderItemName,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity,

            }).ToList(),
            Status = new OrderStatus { Status = OrderState.Pending }
        };

        order = await _orderRepository.CreateOrderAsync(order);
        return new OrderDto
        {
            Id = order.Id,
            OrderDate = order.OrderDate,
            TotalAmount = order.TotalAmount,
            ShippingAddress = order.ShippingAddress,
            CustomerId = order.CustomerId,
            Status = order.Status.Status.ToString(),
            PaymentMethodId = order.PaymentMethodId
        };
    }
}