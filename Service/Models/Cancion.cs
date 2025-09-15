using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public decimal Duracion { get; set; }
        public int DiscoId { get; set; }
        public Disco? Disco { get; set; }
        public bool IsDeleted { get; set; } = false;
        public override string ToString()
        {
            return $"Titulo: {Titulo}, Disco: {Disco}, Duracion: {Duracion}";
        }
    }
}
