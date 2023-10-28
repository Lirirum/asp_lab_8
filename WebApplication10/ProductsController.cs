using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;

namespace WebApplication10
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Random random = new Random();


            var products = new List<Product>
        {   

            new Product { ID = 1, Name = "Product 1", Price = (decimal)random.Next(100, 2000), CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Product 2", Price = (decimal)random.Next(100, 5000), CreatedDate = DateTime.Now },
            new Product { ID = 3, Name = "Product 3", Price = (decimal)random.Next(100, 1000), CreatedDate = DateTime.Now }
        };

            
            return View( "./Views/Index.cshtml", products);
        }
    }
}
