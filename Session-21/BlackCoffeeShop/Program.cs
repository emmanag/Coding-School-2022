

using BlackCoffeeshop.EF.Configuration;
using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;
using CoffeeShop.EF.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationContext>();

var useMocks = Boolean.Parse(builder.Configuration["UseMocks"]);
if (!useMocks) {
    builder.Services.AddScoped<IEntityRepo<ProductCategory>, ProductCategoryRepo>();
    builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
    builder.Services.AddSingleton<IEntityRepo<Employee>, EmployeeRepo>();
    builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();


    builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();
    builder.Services.AddScoped<IEntityRepo<Transaction>, TransactionRepo>();
    builder.Services.AddScoped<IEntityRepo<Product>, ProductRepo>();
}
else {
    builder.Services.AddSingleton<IEntityRepo<ProductCategory>, MockProductCategory>();
    builder.Services.AddSingleton<IEntityRepo<Product>, MockProduct>();
    builder.Services.AddSingleton<IEntityRepo<Customer>, MockCustomerRepo>();
    builder.Services.AddSingleton<IEntityRepo<Employee>, MockEmployeeRepo>();

}


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
