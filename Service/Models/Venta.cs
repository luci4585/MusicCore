using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }

        // FK → Cliente
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public int Cantidad { get; set; }
        public bool IsDeleted { get; set; } = false;

        // Relación con muchos discos
        public ICollection<DiscoVenta> DiscoVentas { get; set; } = new List<DiscoVenta>();

        public override string ToString()
        {
            // Creamos un string con los títulos de los discos vendidos
            string discos = DiscoVentas != null && DiscoVentas.Any()
                             ? string.Join(", ", DiscoVentas.Select(dv => dv.Disco?.Titulo ?? "Sin título"))
                             : "Sin discos";

            return $"Fecha: {Fecha}, Precio: {Precio}, Cantidad: {Cantidad}, Cliente: {Cliente?.Nombre ?? "Sin cliente"}, Discos: {discos}";
        }

    }
}
