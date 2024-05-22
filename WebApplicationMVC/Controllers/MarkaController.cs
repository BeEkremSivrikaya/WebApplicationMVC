using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class MarkaController : Controller
    {
        private AppDbContext _context;

        public MarkaController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var marka = _context.Markalar.ToList();
            return View(marka);
        }
        [HttpGet]
        public IActionResult Marka_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Marka_Kaydet()
        {

            var isim = HttpContext.Request.Form["İsim"].ToString();
   


            Marka yeniMarka = new Marka() { İsim = isim};

            _context.Markalar.Add(yeniMarka);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Ürünlere_Git()
        {
            return RedirectToAction("Index", "Ürün");
        }

    }
}
