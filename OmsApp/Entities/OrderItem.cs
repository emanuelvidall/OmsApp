namespace OmsApp.Entities;

public class OrderItem
{
    public int Id { get; set; }
    
    public int OrdemId { get; set; }
    
    public Order? Order { get; set; }
    
    public string? OrdemItemName { get; set; }

    public decimal UnitPrice { get; set; }
    
    public int Quantity { get; set; }
    
}