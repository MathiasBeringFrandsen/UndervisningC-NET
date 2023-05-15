using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index(string id, string navn)
        {
            if (!String.IsNullOrEmpty(id))
                ViewBag.id = id;
            else
                ViewBag.id = "no id";
            if (!String.IsNullOrEmpty(navn))
                ViewBag.name = navn;
            else
                ViewBag.name = "no name";
            return View("Index");
        }

        public ActionResult Find(string Firstname, string Lastname)
        {
            Person person = new Person();
            person.FirstName = Firstname;
            person.LastName = Lastname;
            person.Age = 23;
            return View("FoundPerson", person);
        }

        public ActionResult Create()
        {
            return View("Create");
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
