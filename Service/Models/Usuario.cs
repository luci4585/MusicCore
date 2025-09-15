using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Enums.TipoUsuarioEnum TipoUsuario { get; set; } = Enums.TipoUsuarioEnum.Administrador;

        public override string ToString()
        {
            return $"{NombreUsuario} ({Email}) - {TipoUsuario}";
        }
    }
}
