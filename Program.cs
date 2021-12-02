using Microsoft.EntityFrameworkCore;
using Lab2___Core.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ITIContext>(n=>n.UseSqlServer(builder.Configuration.GetConnectionString("iticon")));

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


//Scaffold-DbContext "Server=DESKTOP-97RANSU\MOSTAFA;Database=ITI;Trusted_Connection=True;"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models