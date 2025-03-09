using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SmartMeter.Models;

[Table("meter_transactions")]
public class MeterTransaction : BaseModel
{
    [PrimaryKey("id")]
    public long Id { get; set; }

    [Column("meter_id")]
    public string MeterId { get; set; } = string.Empty;

    [Column("amount")]
    public double Amount { get; set; }

    [Column("user_id")]
    public Guid UserId { get; set; }

    [Column("purchase_times")]
    public int PurchaseTimes { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}