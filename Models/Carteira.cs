using System.ComponentModel.DataAnnotations;

namespace ControleDeGastos.Models
{
    public class Carteira
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
    }
}
