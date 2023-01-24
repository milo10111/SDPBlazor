using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;
using SDPBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices(conf =>
{
    conf.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomCenter;
    conf.SnackbarConfiguration.VisibleStateDuration = 3000;
});
await builder.Build().RunAsync();
