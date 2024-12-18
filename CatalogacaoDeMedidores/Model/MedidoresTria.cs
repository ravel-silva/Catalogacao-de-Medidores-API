using System.ComponentModel.DataAnnotations;

namespace CatalogacaoDeMedidores.Model
{
    public class MedidoresTria
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string NumeroTria { get; set; }
        public DateTime DataTria { get; set; } = DateTime.Now;
        public string Tipo { get; } = "Tria";

    }
}
