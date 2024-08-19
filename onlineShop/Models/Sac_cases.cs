using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace onlineShop.Models;

public class Sac_cases : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("case_number")]
    public string CaseNumber { get; set; }
    
    [Column("customer_id")]
    public int CustomerId { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("status")]
    public string Status { get; set; }
   
} 