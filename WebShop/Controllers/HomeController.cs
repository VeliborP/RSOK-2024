using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShop.DAL.Models;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebShopContext _db;

        public HomeController(ILogger<HomeController> logger, WebShopContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var kategorija2 = _db.Kategorijas.Single(k => k.Id == 1);
            _db.Kategorijas.Remove(kategorija2);
            _db.SaveChanges();

            //var kategorija2 = _db.Kategorijas.Single(k => k.Id == 2);
            //kategorija2.Naziv = "Periferije1";
            //_db.SaveChanges();

            //var kategorija = new Kategorija
            //{
            //    Naziv = "Racunarska oprema"
            //};

            //_db.Kategorijas.Add(kategorija);
            //_db.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var model = new ErrorViewModel { RequestId = "Ovo je request ID" };

            return View(model);
        }
    }
}
