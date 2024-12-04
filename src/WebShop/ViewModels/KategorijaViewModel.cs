using System.ComponentModel.DataAnnotations;

namespace WebShop.ViewModels
{
    public class KategorijaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv je obavezno polje")]
        [MaxLength(50, ErrorMessage = "Maksimalna duzina naziva je 50 karaktera")]
        public required string Naziv { get; set; }

        [MaxLength(500, ErrorMessage = "Maksimalna duzina opisa je 500 karaktera")]
        public string? Opis { get; set; }

        
    }
}
