using Microsoft.AspNetCore.Mvc;
using lab9.Models;
using System.Collections.Generic;

namespace lab9.Components
{
    public class ProductTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<Product> products)
        {
            return View(products);
        }
    }
}
