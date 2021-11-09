using AspNetWebAppDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult FileSum() {
            
            string filename = @"C:\users\zenid\desktop\bootcamp_koulutus\training\trainingday_7\AspNetWebAppDemo\AspNetWebAppDemo\wwwroot\files\numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            int sum = 0;
            foreach (string line in lines)
            {
                int value = int.Parse(line);
                sum += value; // sum = sum + value;
            }

            ViewBag.SourceOfData = filename;
            ViewBag.CalculatedSum = sum;

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Colourful()
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
