﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcDatabaseDemo2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDatabaseDemo2.Controllers
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
            NorthwindContext context = new();
            List<Customer> allCustomers = context.Customers.ToList();

            ViewBag.AllCustomers = allCustomers;

            return View();
        }

        public IActionResult Orders()
        {
            NorthwindContext context = new();
            List<Order> allOrders = (from o in context.Orders
                                     where o.EmployeeId == 2
                                     orderby o.OrderDate descending
                                     select o).ToList();

            ViewBag.AllOrders = allOrders;

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
