using Blazored.Toast.Services;
using Blazored.Toast;
using depooo.Client;
using depooo.Client.Services.Abstract;
using depooo.Client.Services.Concrete;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredToast();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddAuthorizationCore();
builder.Services.AddOptions();
await builder.Build().RunAsync();
