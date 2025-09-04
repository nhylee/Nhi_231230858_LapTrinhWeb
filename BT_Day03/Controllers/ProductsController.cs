using Microsoft.AspNetCore.Mvc;
using BT_Day03.Models;

namespace BT_Day03.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Trangchu>
            {
                new Trangchu {
                    Id = 1,
                    Title  = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Image = "/image/product/noicom.jpg"
                },
                new Trangchu {
                    Id = 2,
                    Title  = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Image = "/image/product/noicom.jpg"
                    },
                new Trangchu {
                    Id = 3,
                    Title  = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Image = "/image/product/noicom.jpg"
                }
            };
            return View(products);
        }
    }
}
