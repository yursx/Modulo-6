using System.ComponentModel.DataAnnotations;

namespace AgenciaUpAPI.Models
{
    public class Passagens
    {
        [Key]
        public int Id_passagem { get; set; }
        [Required]
        public int Id_cliente { get; set; }
        [Required]
        public string Saida_viagem { get; set; }
        [Required]
        public string Destino_viagem { get; set; }
        [Required]
        public string Data_viagem { get; set; }
        [Required]
        public double Preco {  get; set; }
        public List <Clientes> Clientes { get; set;}

    }
}
