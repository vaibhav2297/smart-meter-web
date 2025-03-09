namespace SmartMeter.Models;

public enum Pages
{
    SignIn,
    WalletTransaction,
    MeterLogs
}

public static class PagesExtensions
{
    public static string ToRoutePath(this Pages page)
    {
        return page switch
        {
            Pages.SignIn => "/",
            Pages.WalletTransaction => "/wallet-transactions",
            Pages.MeterLogs => "/meter-logs",
            _ => page.ToString() // Default fallback
        };
    }
}