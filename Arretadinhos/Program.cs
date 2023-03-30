using Microsoft.EntityFrameworkCore;
using Arretadinhos.Models;
using Arretadinhos.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ArretadinhosContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ArretadinhosContext"), builder => builder.MigrationsAssembly("Arretadinhos")));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    using var serviceScope = app.Services.CreateScope();
    var seedingService = serviceScope.ServiceProvider.GetRequiredService<SeedingService>();
    seedingService.Seed();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
