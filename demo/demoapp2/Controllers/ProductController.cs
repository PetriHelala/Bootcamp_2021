using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoapp2.Controllers
{
    public class ProductController : Controller
    {
        ProductDBAccessLayer proddb = new ProductDBAccessLayer();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind] ProductEntities productEntities)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resp = proddb.AddProductRecord(productEntities);
                    TempData["msg"] = resp;
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }
    }
}