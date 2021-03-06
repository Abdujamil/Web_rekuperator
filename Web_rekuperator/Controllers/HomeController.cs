﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_proekt.Models;
using Web_rekuperator.Models;

namespace rekuperatorProekt.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult ResultData(Model data)
        {
            data.Calculate();

            ResultModel result = data.Rachet();

            return View(result);
        }
        public IActionResult GraResultData()
        {
            ViewBag.x = Model.ArrayX;
            ViewBag.y = Model.ArrayY;

            return View();
        }

        public IActionResult OutputData()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
