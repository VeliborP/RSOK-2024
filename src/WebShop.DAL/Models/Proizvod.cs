namespace WebShop.DAL.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        public required string Naziv { get; set; }
        public required string Sifra { get; set; }
        public string? KratakOpis { get; set; }
        public string? Opis { get; set; }
        public int? KategorijaId { get; set; }
        public virtual Kategorija Kategorija { get; set; }
    }
}
