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
                Naziv = $"{kategorijaViewModel.Prefiks}-{kategorijaViewModel.Naziv}"
            };
        }

        public static KategorijaViewModel MapKategorijaToKategorijaViewModel(Kategorija kategorijaViewModel)
        {
            return new KategorijaViewModel
            {
                Id = kategorijaViewModel.Id,
                Naziv = kategorijaViewModel.Naziv,
                Prefiks = kategorijaViewModel.Naziv.Split("-")[0].ToString()
            };
        }
    }
}
