using demoapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace demoapp.Controllers
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

        public IActionResult Products()
        {

            MusicStoreDatabaseContext context = new();
            List<Product> allProducts = context.Products.ToList();

            ViewBag.AllProducts = allProducts;

            return View();
        }

        /* public IActionResult GetImage(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<ImageViewModel> ImageViews = new List<ImageViewModel>();
            var ImageList = (from product in db.Products select new { product.ProductData }).ToList();

            return View(ImageViews);
        }
        */

        public IActionResult Delivery()
        {
            return View();
        }

        public IActionResult Contact()
        {
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
    }
}
