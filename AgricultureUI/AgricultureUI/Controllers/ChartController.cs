using AgricultureUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgricultureUI.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductChart()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                productname = "Buğday",
                productvalue = 850
            });
            products.Add(new Product
            {
                productname = "Mercimek",
                productvalue = 481
            });
            products.Add(new Product
            {
                productname = "Arpa",
                productvalue = 250
            });
            products.Add(new Product
            {
                productname = "Pirinç",
                productvalue = 120
            });
            products.Add(new Product
            {
                productname = "Domates",
                productvalue = 960
            });
            return Json(new { jsonlist = products });
        }

    }
}
