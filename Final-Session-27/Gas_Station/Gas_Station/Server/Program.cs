using Gas_Station.EF.Configuration;
using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ResponseCompression;
using Gas_Station.EF.Context;
using Gas_Station.EF.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//DBContext
builder.Services.AddDbContext<GasStationContext>();

builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();
builder.Services.AddScoped<IEntityRepo<Item>, ItemRepo>();
builder.Services.AddScoped<IEntityRepo<Transaction>, TransactionRepo>();
builder.Services.AddScoped<IEntityRepo<TransactionLine>, TransactionLineRepo>();
builder.Services.AddScoped<IEntityRepo<Ledger>, LedgerRepo>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
