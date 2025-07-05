using IdesseCaseStudy.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using IdesseCaseStudy.Services;
using Refit;

var cookieContainer = new System.Net.CookieContainer(); 
var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<UserStateService>();
builder.Services.AddRefitClient<IInfiniApi>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri("https://test1.idesse.com");
    })
    .ConfigurePrimaryHttpMessageHandler(() =>
        new HttpClientHandler
        {
            UseCookies = true,
            CookieContainer = cookieContainer 
        });



var app = builder.Build();
 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
