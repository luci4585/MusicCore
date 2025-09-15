using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Models
{
    public class DiscoVenta
    {
        public int Id { get; set; }

        // FK → Venta
        public int VentaId { get; set; }
        public Venta? Venta { get; set; }

        // FK → Disco
        public int DiscoId { get; set; }
        public Disco? Disco { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public bool IsDeleted { get; set; } = false;
    }

}
