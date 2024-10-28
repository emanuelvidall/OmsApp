namespace OmsApp.Repositories;

public class OrderStatusRepository
{
    private readonly AppDbContext _context;

    public OrderStatusRepository(AppDbContext context)
    {
        _context = context;
    }
    
}