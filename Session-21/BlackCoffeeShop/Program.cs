

using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationContext>();
builder.Services.AddSingleton<IEntityRepo<Customer>, MockCustomerRepo>();
//var useMocks = Boolean.Parse(builder.Configuration["UseMocks"]);
//if (!useMocks)
//{
//    //builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
//}
//else
//{
//    builder.Services.AddSingleton<IEntityRepo<Customer>, MockCustomerRepo>();
//}


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
