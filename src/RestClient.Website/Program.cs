using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestClient.Infra.Dtos;
using RestClient.Orm;
using RestClient.Orm.Models;
using RestClient.ORM.Mapping;
using RestClient.ORM.Repositories;
using RestClient.ORM.Services;
using RestClient.Website;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("default_db_connection"));
    options.EnableSensitiveDataLogging();
});
  
builder.Services.AddScoped<DataProvider>();

// Add the repositories.
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
builder.Services.AddScoped<DataModelColumnService>();
builder.Services.AddScoped<DataModelService>();
builder.Services.AddScoped<DataTypeService>();
builder.Services.AddScoped<EndpointHeaderArgumentService>();
builder.Services.AddScoped<EndpointQueryStringService>();
builder.Services.AddScoped<EndpointService>();
builder.Services.AddScoped<HistoryService>();

// Mapping
builder.Services.AddScoped<ApiMapper>();
builder.Services.AddScoped<DataModelColumnMapper>();
builder.Services.AddScoped<DataModelMapper>();
builder.Services.AddScoped<DataTypeMapper>();
builder.Services.AddScoped<EndpointHeaderArgumentMapper>();
builder.Services.AddScoped<EndpointQueryStringMapper>();
builder.Services.AddScoped<HistoryMapper>();

builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());


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
