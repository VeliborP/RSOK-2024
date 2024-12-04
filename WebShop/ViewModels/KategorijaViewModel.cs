using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;
using WebShop.DAL.Models;

namespace WebShop.ViewModels
{
    public class KategorijaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv je obavezno polje")]
        [MaxLength(50, ErrorMessage = "Maksimalna duzina naziva je 50 karaktera")]
        public string Naziv { get; set; }

        public string Prefiks { get; set; }

        
    }
}
