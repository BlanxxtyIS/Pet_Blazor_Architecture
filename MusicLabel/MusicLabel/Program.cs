using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MusicLabel;
using MudBlazor.Services;
using MusicLabel.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<AlbumService>();
builder.Services.AddMudServices();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
