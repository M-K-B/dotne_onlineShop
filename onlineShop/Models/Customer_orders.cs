
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace onlineShop.Models;

public class Customer_orders : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("order_number")]
    public string OrderNumber { get; set; }
    
    [Column("customer_id")]
    public int CustomerId { get; set; }
    
    [Column("order_date ")]
    public DateTime OrderDate { get; set; }
    
    [Column("total_amount")]
    public decimal TotalAmount { get; set; }
    
    [Column("shipping_first_line_address")]
    public string ShippingFirstLineAddress { get; set; }
    
    [Column("shipping_postcode")]
    public string ShippingPostcode { get; set; }
    
    [Column("shipping_city")]
    public string ShippingCity { get; set; }
    
    
    
}