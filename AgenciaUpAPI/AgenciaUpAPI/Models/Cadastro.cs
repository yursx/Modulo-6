using System.ComponentModel.DataAnnotations;

namespace AgenciaUpAPI.Models
{
    public class Cadastro
    {
        [Key]
        public int Id_cliente {  get; set; }
        [Required]
        public string Nome_cliente { get; set; }
        [Required] 
        public string Email_cliente { get; set; }
        [Required]
        public string Senha_cliente { get; set; }
        [Required]
        public int Telefone {  get; set; }
        [Required]
        public int CPF { get; set; }
    }
}
