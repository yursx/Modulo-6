using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AgenciaUpAPI.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public List <Passagens> Passagens { get; set; }
    }
}
