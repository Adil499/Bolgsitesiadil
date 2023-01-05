using Microsoft.AspNetCore.Mvc;

namespace Bolgsitesi.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult anasayfa()
        {
            return View();
        }
    }
}
