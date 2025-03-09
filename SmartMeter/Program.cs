using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SmartMeter;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Supabase
var options = new Supabase.SupabaseOptions
{
    AutoConnectRealtime = true,
    AutoRefreshToken = true
};
builder.Services.AddSingleton(_ => new Supabase.Client(supabaseUrl: "https://irrhqpjwtgmdpxjcriit.supabase.co", supabaseKey: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImlycmhxcGp3dGdtZHB4amNyaWl0Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MjYzNzUwODEsImV4cCI6MjA0MTk1MTA4MX0.s4T2siqzpFEOEaSfjpdJD8VyWRZUP7B_tQU5sBsH60w", options));

await builder.Build().RunAsync();