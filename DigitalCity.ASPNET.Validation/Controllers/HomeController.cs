using DigitalCity.ASPNET.Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalCity.ASPNET.Validation.Controllers
{


    public class HomeController : Controller
    {
        private static ICollection<Product> _product = new List<Product>()
        {
            new Product() { Id = 1, Name ="Pomme", Price=2 },
            new Product() { Id = 2, Name ="Poire", Price=3 },
            new Product() { Id = 3, Name ="Cannard", Price=16 }
        };

        private int LastId=3;

        public IActionResult Index()
        {
            return View(_product);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add([FromForm] ProductForm productForm)
        {

            if (ModelState.IsValid)
            {
                Product newProduct = new Product()
                {
                    Id = ++LastId,
                    Name = productForm.Name,
                    Price = productForm.Price
                };
                _product.Add(newProduct);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}