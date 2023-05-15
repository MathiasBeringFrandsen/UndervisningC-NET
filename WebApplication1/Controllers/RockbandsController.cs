using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {
            string[] bands = { "Foo Fighters", "Muse", "Sum 41", "Blink 182", "The Killers", "Metallica", "Weezer", "Hell is for Heroes", "The Cardigans", "Mew"};
            ViewBag.Bands = bands;
            return View();
        }
    }
}
