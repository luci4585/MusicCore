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

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public int DiscoId { get; set; }
        public Disco? Disco { get; set; }

        public int Cantidad { get; set; }
        public bool IsDeleted { get; set; } = false;

        // Relación con muchos discos
        //public ICollection<DiscoVenta> DiscoVentas { get; set; } = new List<DiscoVenta>();

        public override string ToString()
        {
            return $"Fecha: {Fecha}, Precio: {Precio}, Cantidad: {Cantidad}, Cliente: {Cliente?.Nombre ?? "Sin cliente"}, Discos: {Disco?.Titulo}";
        }

    }
}
