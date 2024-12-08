using Microsoft.AspNetCore.Mvc;
using lab9.Models;
using System.Collections.Generic;

namespace lab9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Product A", Price = 10.99M },
                new Product { ID = 2, Name = "Product B", Price = 20.50M },
                new Product { ID = 3, Name = "Product C", Price = 15.75M }
            };

            ViewData["City"] = "London";
            return View(products);
        }
    }
}
