using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; } = "";
        public string? Email { get; set; }
        public bool IsDeleted { get; set; } = false;

        public override string ToString()
        {
           return $"{Nombre} ({Email})";
        }
    }
}
