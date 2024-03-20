using Auction.Blazor;
using Auction.Blazor.Services;
using Auction.Blazor.Services.Interfaces;
using BlazorAppAgenda.Client;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseUrl = "https://localhost:7041";
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(baseUrl)
});
builder.Services.AddScoped<ICreateOfferService, CreateOfferService>();
builder.Services.AddScoped<IManageOffersService, ManageOffersService>();
builder.Services.AddScoped<IManageAuctionService, ManageAuctionService>();
builder.Services.AddScoped<IManageItemsService, ManageItemsService>();
builder.Services.AddScoped<IManageUsersService, ManageUsersService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
await builder.Build().RunAsync();
