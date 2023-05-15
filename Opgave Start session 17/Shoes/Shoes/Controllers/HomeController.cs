using Microsoft.AspNetCore.Mvc;
using Shoes.Models;
using System.Diagnostics;

namespace Shoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Shoe shoe)
        {
            if (!ModelState.IsValid)
            {
                Debug.Write("Model state is NOT valid");
                return View(shoe);
            } 
            else
            {
                ModelState.Clear();
                return View();
            }
        }
    }
}