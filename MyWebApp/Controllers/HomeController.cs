using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Repositories;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly TestRepository repository = new TestRepository();
        //public HomeController(TestRepository _repository)
        //{
        //    repository = _repository;
        //}
        public IActionResult Index()
        {
            var data = repository.GetList();
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
