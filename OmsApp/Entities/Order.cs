namespace OmsApp.Entities;

public class Order
{
    public int Id { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public decimal TotalAmount { get; set; }
    
    public string ShippingAddress { get; set; }
    
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    
    public int? OrderStatusId { get; set; } 
    public OrderStatus? Status { get; set; }  

    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    
    // Collection of OrderItems
    public ICollection<OrderItem> OrderItems { get; set; }
}