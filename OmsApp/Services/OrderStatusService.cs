using OmsApp.Dtos;
using OmsApp.Entities;

namespace OmsApp.Services;

public class OrderStatusService
{
    private readonly AppDbContext _context;

    public OrderStatusService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<OrderStatus> CreateOrderStatusAsync(OrderStatusCreateDto orderStatusCreateDto)
    {
        var order = await _context.Orders.FindAsync(orderStatusCreateDto.OrderId);
        if (order == null)
        {
            throw new ArgumentException("Invalid order ID");
        }
        
        if (!Enum.TryParse<OrderState>(orderStatusCreateDto.Status, true, out var orderState))
        {
            throw new ArgumentException("Invalid status value");
        }

        var orderStatus = new OrderStatus
        {
            OrderId = order.OrderId,
            Status = orderState,
        };
        
        _context.OrderStatuses.Add(orderStatus);
        await _context.SaveChangesAsync();
        
        return orderStatus;
    }
}