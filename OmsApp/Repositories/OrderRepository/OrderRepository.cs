using Microsoft.EntityFrameworkCore;
using OmsApp.Entities;

namespace OmsApp.Repositories.OrderRepository;

public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _context;

    public OrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Order>> GetAllOrdersAsync()
    {
        return await _context.Orders.Include(o => o.Status)
            .Include(o => o.Customer)
            .Include(o => o.OrderItems)
            .Include(o => o.PaymentMethod).ToListAsync();
    }

    public async Task<Order> CreateOrderAsync(Order order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        return order;
    }
}