﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View(new Person("Alin", 14, DateTime.Now));
        }
    }
}
