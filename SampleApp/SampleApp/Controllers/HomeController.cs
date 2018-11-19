using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Models;

namespace SampleApp.Controllers
{
    public class HomeController : Controller
    {   
        public ViewResult Index()
        {
            ViewBag.Hello = "Hello";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult ResponseForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ResponseForm(Guest guest)
        {
            return View();
        }
    }
}
