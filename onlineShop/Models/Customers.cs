using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace onlineShop.Models;

public class Customers : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("name")]
    public string? Name { get; set; }
    
    [Column("email")]
    public string? Email { get; set; }
    
    [Column("first_line_address")]
    public string? FirstLineAddress { get; set; }
    
    [Column("postcode")]
    public string? Postcode { get; set; }
    
    [Column("city")]
    public string? City { get; set; }
}