using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Utils
{
    public static class ApiEndpoints
    {
        public static string Artista { get; set; } = "artistas";
        public static string Usuario { get; set; } = "usuarios";
        public static string Cancion { get; set; } = "canciones";
        public static string Cliente { get; set; } = "clientes";
        public static string Disco { get; set; } = "discos";
        public static string DiscoVenta { get; set; } = "discosventas";
        public static string Genero { get; set; } = "generos";
        public static string Venta { get; set; } = "ventas";


        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Artista) => Artista,
                nameof(Usuario) => Usuario,
                nameof(Cancion) => Cancion,
                nameof(Cliente) => Cliente,
                nameof(Disco) => Disco,
                nameof(DiscoVenta) => DiscoVenta,
                nameof(Genero) => Genero,
                nameof(Venta) => Venta,

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}