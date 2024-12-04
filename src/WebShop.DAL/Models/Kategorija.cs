namespace WebShop.DAL.Models;

public partial class Kategorija
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public string Opis { get; set; }
}
