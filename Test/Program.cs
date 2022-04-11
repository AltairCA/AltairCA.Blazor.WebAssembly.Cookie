using AltairCA.Blazor.WebAssembly.Cookie;
using AltairCA.Blazor.WebAssembly.Cookie.Framework;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Test;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddAltairCACookieService(options =>
{
    options.DefaultExpire = TimeSpan.FromMinutes(15);
});
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();