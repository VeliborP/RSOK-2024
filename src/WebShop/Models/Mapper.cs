using WebShop.DAL.Models;
using WebShop.ViewModels;

namespace WebShop.Models
{
    public static class Mapper
    {
        public static Kategorija MapKategorijaViewModelToKategorija(KategorijaViewModel kategorijaViewModel)
        {
            return new Kategorija
            {
                Id = kategorijaViewModel.Id,
                Naziv = kategorijaViewModel.Naziv,
                Opis = kategorijaViewModel.Opis
            };
        }

        public static KategorijaViewModel MapKategorijaToKategorijaViewModel(Kategorija kategorijaViewModel)
        {
            return new KategorijaViewModel
            {
                Id = kategorijaViewModel.Id,
                Naziv = kategorijaViewModel.Naziv,
                Opis = kategorijaViewModel.Opis
            };
        }
    }
}
