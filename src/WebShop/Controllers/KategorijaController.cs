using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.DAL.Models;
using WebShop.Models;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class KategorijaController : Controller
    {
        private readonly WebShopContext _context;

        public KategorijaController(WebShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var kategorijeDb = await _context.Kategorijas.ToListAsync();
            var kategorijeViewModel = new List<KategorijaViewModel>();

            foreach(var kategorija in kategorijeDb)
            {
                kategorijeViewModel.Add(
                    new KategorijaViewModel
                    {
                        Id = kategorija.Id,
                        Naziv = kategorija.Naziv,
                        Opis = kategorija.Opis
                    });
            }

            return View(kategorijeViewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategorija = await _context.Kategorijas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kategorija == null)
            {
                return NotFound();
            }

            return View(Mapper.MapKategorijaToKategorijaViewModel(kategorija));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(KategorijaViewModel kategorija)
        {
            var postojiKategorija = _context.Kategorijas.Any(k => k.Naziv.Equals(kategorija.Naziv.Trim()));
            if (postojiKategorija)
                ModelState.AddModelError("Naziv", "Kategroija sa nazivom vec postoji!");

            if (ModelState.IsValid)
            {
                var kategorijaDb = Mapper.MapKategorijaViewModelToKategorija(kategorija);
                _context.Add(kategorijaDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kategorija);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategorija = await _context.Kategorijas.FindAsync(id);
            if (kategorija == null)
            {
                return NotFound();
            }
            return View(Mapper.MapKategorijaToKategorijaViewModel(kategorija));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, KategorijaViewModel kategorija)
        {
            if (id != kategorija.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var kategorijaDb = Mapper.MapKategorijaViewModelToKategorija(kategorija);
                    _context.Update(kategorijaDb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KategorijaExists(kategorija.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(kategorija);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategorija = await _context.Kategorijas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kategorija == null)
            {
                return NotFound();
            }

            return View(Mapper.MapKategorijaToKategorijaViewModel(kategorija));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kategorija = await _context.Kategorijas.FindAsync(id);
            if (kategorija != null)
            {
                _context.Kategorijas.Remove(kategorija);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KategorijaExists(int id)
        {
            return _context.Kategorijas.Any(e => e.Id == id);
        }
    }
}
