using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebbApp.Helpers.Repositories;
using WebbApp.Helpers.Services;
using WebbApp.Models.Contexts;
using WebbApp.Models.Dtos;
using WebbApp.Models.Identities;
using Webbappen.Repositories;
using Webbappen.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<UserAddresRepository>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<SeedService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<TagService>();
builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<ProductTagRepository>();


builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Identity")));
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Data")));
builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = true;
    

})
    .AddEntityFrameworkStores<IdentityContext>()
    .AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>();
    

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/Account/Login";
    x.LogoutPath = "/";
    x.AccessDeniedPath = "/denied";

});






var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
