using EventoApp.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using EventoApp.Core.Services;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:6001/") });
builder.Services.AddRefitClient<IEventoService>().ConfigureHttpClient( h => {
    h.BaseAddress = new Uri("https://localhost:6001");
});

builder.Services.AddRefitClient<IWeatherService>().ConfigureHttpClient(h => {
    h.BaseAddress = new Uri("https://localhost:6001");
});

builder.Services.AddMudServices();

await builder.Build().RunAsync();
