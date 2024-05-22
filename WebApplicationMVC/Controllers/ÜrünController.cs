using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class ÜrünController : Controller
    {

        private AppDbContext _context;

        public ÜrünController(AppDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var ürün = _context.Ürünler.ToList();
            return View(ürün);
        }
        public IActionResult Ürün_Detay(int id)
        {
            var ürün = _context.Ürünler.Find(id);
            return View(ürün);
        }
        [HttpGet]
        public IActionResult Ürün_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ürün_Ekle(Ürün ürün)
        {
            _context.Ürünler.Add(ürün);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Ara(string Aranan)
        {
            var ürünler = _context.Ürünler.Where(u => u.İsim.Contains(Aranan) || u.Açıklama.Contains(Aranan)).ToList();

            return View("Index", ürünler);
        }

        public IActionResult Markaya_Git()
        {
            return RedirectToAction("Index", "Marka");
        }
        public IActionResult Kategoriye_Git()
        {
            return RedirectToAction("Index", "Kategori");
        }

    }
}
