using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SmartMeter.Models;

[Table("wallet_transactions")]
public class WalletTransaction : BaseModel
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

    [Column("transaction_type")] public string TransactionType { get; set; } = string.Empty;
    
    [Column("purchase_frequency")]
    public int PurchaseFrequency { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}