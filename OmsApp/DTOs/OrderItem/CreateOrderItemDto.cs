namespace OmsApp.DTOs.OrderItem;

public class CreateOrderItemDto
{
    public string? OrderItemName { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}