using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebBlazor;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Aquí va tu componente principal (App.razor), no Disco
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registrar HttpClient para llamadas a API
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
