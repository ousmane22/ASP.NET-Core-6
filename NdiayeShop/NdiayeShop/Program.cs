using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using NdiayeShop.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NdiayeShopDbContext>(options =>
{
    options.UseSqlServer(
      builder.Configuration.GetConnectionString("NdiayeShopConnection"));
});
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IPieRepository,PieRepository>();

var app = builder.Build();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();
