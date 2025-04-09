using LTWed_BanHangTrucTuyen.Data;
using LTWed_BanHangTrucTuyen.Models;
using LTWed_BanHangTrucTuyen.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>() // ? �?i IdentityUser -> ApplicationUser
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<IOrderRepository, EFOrderRepository>();
builder.Services.AddScoped<IAddressRepository, EFAddressRepository>();
builder.Services.AddScoped<IReviewRepository, EFReviewRepository>();
builder.Services.AddScoped<IWarehouseTransactionRepository, EFWarehouseTransactionRepository>();
builder.Services.AddScoped<IPromotionRepository, EFPromotionRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles(); // ? �?m b?o b?n c� x? l? static files

app.UseRouting();

app.UseAuthentication(); // ? B?t bu?c n?u d�ng Identity
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); // ? Th�m d?u ch?m ph?y

app.Run();

