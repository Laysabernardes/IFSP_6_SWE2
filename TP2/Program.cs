using Microsoft.EntityFrameworkCore;
using TP2.Models; // importa o ApplicationDbContext e os Models

var builder = WebApplication.CreateBuilder(args);

// Configura��o do banco de dados (SQLite para facilitar)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona suporte a Controllers e Views (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura��o do pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // seguran�a: for�a HTTPS com HSTS
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // habilita uso de CSS, JS e imagens (wwwroot)

app.UseRouting();
app.UseAuthorization();

// Configura��o das rotas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
