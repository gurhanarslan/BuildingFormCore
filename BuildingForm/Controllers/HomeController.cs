using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuildingForm.Models;

namespace BuildingForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Create create)
        {
            Repository.AddCreate(create);
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            return View(Repository.creates);
        }
        [HttpGet]
        public IActionResult Search(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                return View();

            return View("List",Repository.creates.Where(i=>i.Name.Contains(Name)));
        }
    }
}
