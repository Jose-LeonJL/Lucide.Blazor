using BlazorWasm.App;
using Lucide.Blazor.Extensions;
using Lucide.Blazor.Generator;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
    .AddLucideIcons("https://unpkg.com/lucide-static@latest/icons");

var host = builder.Build();
await host.RunAsync();
