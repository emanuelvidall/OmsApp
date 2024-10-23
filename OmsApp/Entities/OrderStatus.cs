namespace OmsApp.Entities;
public enum OrderState
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

public class OrderStatus
{
    public int Id { get; set; }
    
    public OrderState Status { get; set; }
    
    public int OrderId { get; set; }
    
    public Order? Order { get; set; }
    
}