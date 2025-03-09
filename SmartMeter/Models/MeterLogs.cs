using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SmartMeter.Models;

[Table("meter_logs")]
public class MeterLogs : BaseModel
{
    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid UserId { get; set; }

    [Column("meter_id")]
    public string MeterId { get; set; } = string.Empty;

    [Column("purchase_frequency")]
    public int PurchaseFrequency { get; set; }

    [Column("accumulated_usage")]
    public double AccumulatedUsage { get; set; } = 0;

    [Column("surplus_variable")]
    public double SurplusVariable { get; set; } = 0;

    [Column("total_purchase")]
    public double TotalPurchase { get; set; } = 0;

    [Column("battery_voltage")]
    public string BatteryVoltage { get; set; } = string.Empty;

    [Column("valve_status")]
    public string ValveStatus { get; set; } = string.Empty;

    [Column("alarm_variables")]
    public double AlarmVariables { get; set; } = 0;

    [Column("overdraft_variables")]
    public double OverdraftVariables { get; set; } = 0;

    [Column("minimum_usage_variable")]
    public double MinimumUsageVariable { get; set; } = 0;

    [Column("additional_deductions")]
    public double AdditionalDeductions { get; set; } = 0;

    [Column("product_verison")]
    public long ProductVersion { get; set; } = 0;

    [Column("program_version")]
    public long ProgramVersion { get; set; } = 0;

    [Column("inplace_method")]
    public string InplaceMethod { get; set; } = string.Empty;

    [Column("calibration_identification")]
    public string CalibrationIdentification { get; set; } = string.Empty;

    [Column("payment_method")]
    public string PaymentMethod { get; set; } = string.Empty;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
