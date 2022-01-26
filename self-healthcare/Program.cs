using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using self_healthcare.Models;
using Microsoft.AspNetCore.Identity;
using self_healthcare.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<SelfHealthcareContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("SelfHealthcareContext")));
    
    builder.Services.AddDefaultIdentity<WebApp1User>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<IdentityDataContext>();
    builder.Services.AddDbContext<IdentityDataContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("IdentityDataContextConnection")));
}
else
{
    builder.Services.AddDbContext<SelfHealthcareContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionSelfHealthcareContext")));
}

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();