using HotelBookingMVC.Data; // Import kontekstu bazy danych
using Microsoft.EntityFrameworkCore; // Import dla EF Core

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja bazy danych SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Konfiguracja MVC
builder.Services.AddControllersWithViews();

// Konfiguracja Swaggera
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware dla obs�ugi b��d�w w �rodowisku produkcyjnym
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else
{
    // Middleware dla Swaggera
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware dla HTTPS i plik�w statycznych
app.UseHttpsRedirection();
app.UseStaticFiles();

// Middleware dla routingu
app.UseRouting();

// Middleware dla autoryzacji (je�li dodasz p�niej funkcje u�ytkownik�w)
app.UseAuthentication();
app.UseAuthorization();

// Mapowanie trasy domy�lnej dla kontroler�w i widok�w
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Uruchomienie aplikacji
app.Run();
