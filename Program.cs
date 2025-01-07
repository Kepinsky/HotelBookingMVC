using HotelBookingMVC.Data; // Import kontekstu bazy danych
using Microsoft.EntityFrameworkCore; // Import dla EF Core

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja bazy danych SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Konfiguracja MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware dla obs³ugi b³êdów w œrodowisku produkcyjnym
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Middleware dla HTTPS i plików statycznych
app.UseHttpsRedirection();
app.UseStaticFiles();

// Middleware dla routingu
app.UseRouting();

// Middleware dla autoryzacji (jeœli dodasz póŸniej funkcje u¿ytkowników)
app.UseAuthorization();

// Mapowanie trasy domyœlnej dla kontrolerów i widoków
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Uruchomienie aplikacji
app.Run();
