using System;
using MySqlConnector;

namespace MyInventory2026.src.shared.helpers;

public class MySqlVersionResolver 
// detecta la versión de MySQL conectándose y leyendo el ServerVersion
{
    public static Version DetectVersion(string connectionString) // recibe la cadena de texto de conexión, se conecta a la base de datos y devuelve un objeto Version con la versión detectada
    {
        using var conn = new MySqlConnection(connectionString); // crea una conexión a MySQL usando la cadena de conexión proporcionada
        conn.Open();// abre la conexión
        var raw = conn.ServerVersion;//devuelve la version
        var clean = raw.Split('-')[0];// elimina sufijos y deja solo los numeros
        return Version.Parse(clean); // convierte la cadena de texto limpia en un objeto Version y lo devuelve
    }
}