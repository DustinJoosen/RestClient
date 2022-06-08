using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestClient.Infra.Dtos;
using RestClient.Orm;
using RestClient.Orm.Models;
using RestClient.ORM.Repositories;
using RestClient.ORM.Services;
using RestClient.Website;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("default_db_connection")));
  
builder.Services.AddScoped<DataProvider>();

// Add the repositories.
// TODO: maybe an extension method for this???
builder.Services.AddScoped<ApiRepository>();
builder.Services.AddScoped<DataModelColumnRepository>();
builder.Services.AddScoped<DataModelRepository>();
builder.Services.AddScoped<DataTypeRepository>();
builder.Services.AddScoped<EndpointHeaderArgumentRepository>();
builder.Services.AddScoped<EndpointQueryStringRepository>();
builder.Services.AddScoped<EndpointRepository>();
builder.Services.AddScoped<HistoryRepository>();

// Add the services.
builder.Services.AddScoped<ApiService>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
