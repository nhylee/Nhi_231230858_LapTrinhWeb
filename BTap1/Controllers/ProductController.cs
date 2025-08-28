using Microsoft.AspNetCore.Mvc;

namespace BTap1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
           ViewBag.Products= new List<string> { "Laptop", "Dien thoai", "May tinh bang" };
            return View();
        }
        public IActionResult Details() {
            ViewBag.Products = new
            {
                Id = 1,
                Name = "Iphone 16",
                Price = 2000
            };
            return View();
        }
    }
}
