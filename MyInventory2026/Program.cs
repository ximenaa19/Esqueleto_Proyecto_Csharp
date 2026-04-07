
using Microsoft.EntityFrameworkCore.Internal;
using MyInventory2026.src.shared.helpers;

try
{
    var context = DbContextFactory.Create(); // factory para obtener conexion

    if (context.Database.CanConnect()) // capturar errores al conectar - verificacion al conectar
    {
        Console.WriteLine("Conexión exitosa a la base de datos.");
    }
    else
    {
        Console.WriteLine("No se pudo conectar a la base de datos.");
    }
    
}

catch (Exception ex)  // manejo de errores
{
    Console.Error.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
    if (ex.InnerException != null)
    {
        Console.Error.WriteLine($"Detalles adicionales: {ex.InnerException.Message}");//detalles mas profundos
    }
}