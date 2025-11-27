using Microsoft.EntityFrameworkCore;
using Proyecto2025.BE.Data; // Namespace donde está AppDbContext

var builder = WebApplication.CreateBuilder(args);

// -----------------------------
// 1. Registrar servicios en el contenedor de DI
// -----------------------------

// Agrega soporte para controladores (necesario para API)
builder.Services.AddControllers();

// Agrega soporte para Swagger (documentación y pruebas de la API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar AppDbContext para que ASP.NET Core pueda inyectarlo en los controladores
// Aquí definimos la cadena de conexión a SQL Server Express
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// -----------------------------
// 2. Construir la aplicación
// -----------------------------
var app = builder.Build();

// -----------------------------
// 3. Configurar el pipeline HTTP
// -----------------------------

// Activar Swagger solo en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    c.RoutePrefix = string.Empty; // Esto hace que Swagger esté en la raíz "/"
}
);
}

// Redirección a HTTPS
app.UseHttpsRedirection();

// Middleware de autorización (si lo usás)
app.UseAuthorization();

// Mapear los controladores para que respondan a las rutas
app.MapControllers();

// Iniciar la aplicación
app.Run();