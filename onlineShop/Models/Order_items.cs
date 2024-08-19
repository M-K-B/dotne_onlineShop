using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace onlineShop.Models;

public class Order_items : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("order_id")]
    public int OrderId { get; set; }
    
    [Column("product_id")]
    public int ProductId { get; set; }
    
    [Column("quantity")]
    public int Quantity { get; set; }
    
    [Column("price")]
    public decimal Price { get; set; }
}