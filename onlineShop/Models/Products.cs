using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace onlineShop.Models;

public class Products : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("price")]
    public decimal Price { get; set; }
}