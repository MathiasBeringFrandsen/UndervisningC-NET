using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(FormCollection formCollection)
        {
            int hours = Convert.ToInt32(formCollection["Hours"]);
            int minutes = Convert.ToInt32(formCollection["Minutes"]);
            int seconds = Convert.ToInt32(formCollection["Seconds"]);

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;

            ViewBag.Hours = hours;
            ViewBag.Minutes = minutes;
            ViewBag.Seconds = seconds;
            ViewBag.Total = total;

            return View("CalculatorResult");
        }
    }
}
