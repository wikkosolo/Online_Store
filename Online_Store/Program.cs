using Microsoft.EntityFrameworkCore;
using Online_Store.Data;
using Online_Store.Data.Repositories.Interfaces;
using Online_Store.Data.Repositories.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteDatabase"))
);
builder.Services.AddScoped<IUserInterface, UserService>();

var app = builder.Build();

// odamzotlar salomat

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
