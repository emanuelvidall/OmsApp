using OmsApp.DTOs.OrderItem;

namespace OmsApp.Dtos;

public class CreateOrderDto
{
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string? ShippingAddress { get; set; }
    public int CustomerId { get; set; }
    public int PaymentMethodId { get; set; }
    public List<CreateOrderItemDto>? OrderItems { get; set; }
}