using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class KategoriController : Controller
    {

        private AppDbContext _context;

        public KategoriController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var kategori = _context.Kategoriler.ToList();
            return View(kategori);
        }
        [HttpGet]
        public IActionResult Kategori_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Kategori_Kaydet()
        {
            var isim = HttpContext.Request.Form["İsim"].ToString();

            Kategori yeniKategori = new Kategori() { İsim = isim };

            _context.Kategoriler.Add(yeniKategori);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Ürünlere_Git()
        {
            return RedirectToAction("Index", "Ürün");
        }


    }
}
