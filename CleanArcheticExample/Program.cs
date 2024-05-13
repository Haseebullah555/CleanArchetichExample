using Application;
using Persistence;
using CleanArcheticExample.StartUpExtension;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddLocalization(opt => { opt.ResourcesPath = "Resources";});
builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

// Configure supported cultures for localization
//var supportedCultures = new[] {"en-US","fa-IR","ps-AF" };
var supportedCultures = new[]
{
    new CultureInfo("en-US"),
    new CultureInfo("fa-IR"),
    new CultureInfo("pa-AF")
};
builder.Services.Configure<RequestLocalizationOptions>(opt =>
{
    opt.DefaultRequestCulture = new RequestCulture("en-US");
    opt.SupportedCultures = supportedCultures;
    opt.SupportedUICultures = supportedCultures;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
// Enable localization middleware
var localizationOptions = new RequestLocalizationOptions();
app.UseRequestLocalization(localizationOptions);
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
