using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.API.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(20)]
        public string Telefono { get; set; }
        
    }
}
