using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Disco
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;

        // FK → Artista
        public int ArtistaId { get; set; }
        public Artista? Artista { get; set; }

        // FK → Genero
        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }

        public bool IsDeleted { get; set; } = false;

        //public ICollection<Cancion> Canciones { get; set; } = new List<Cancion>();
        //public ICollection<DiscoVenta> DiscoVentas { get; set; } = new List<DiscoVenta>();

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Artista: {Artista}, Genero: {Genero}";
        }
    }
}
