namespace OmsApp.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string ShippingAddress { get; set; }
    public int CustomerId { get; set; }
    public string Status { get; set; }
    public int PaymentMethodId { get; set; }
}