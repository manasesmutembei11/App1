using App1.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using App1.Data;
using Microsoft.AspNetCore.Identity;
using App1.Repositories;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<App1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("App1Context") ?? throw new InvalidOperationException("Connection string 'App1Context' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();;

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new IgnoreAntiforgeryTokenAttribute());
});


builder.Services.AddScoped<IIncomeRepository, IncomeRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddAuthentication().AddCookie("MyCookieAuth", options =>
{
    options.Cookie.Name = "MyCookieAuth";
});

builder.Services.AddAuthentication()
    .AddCookie("Identity.Application") // Specify authentication scheme
    .AddCookie("Identity.External");  // If using external identity providers
builder.Services.AddIdentity<IdentityUser, IdentityRole>();

// In your Startup.cs or equivalent configuration file


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
