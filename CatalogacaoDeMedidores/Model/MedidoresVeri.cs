using System.ComponentModel.DataAnnotations;

namespace CatalogacaoDeMedidores.Model
{
    public class MedidoresVeri
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string NumeroVeri { get; set; }
        public DateTime DataVeri { get; set; } = DateTime.Now;
        public string Tipo { get; } = "Veri";
    }
}
