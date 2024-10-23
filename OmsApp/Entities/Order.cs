namespace OmsApp.Entities;

public class Order
{
    public int Id { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public int TotalAmount { get; set; }
    
    public string ShippingAddress { get; set; }
    
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
    
    public OrderStatus Status { get; set; }
    public int OrderStatusId { get; set; }
    
    public PaymentMethod PaymentMethod { get; set; }
    public int PaymentMethodId { get; set; }
    
    public ICollection<OrdemItem> OrdemItems { get; set; }

}