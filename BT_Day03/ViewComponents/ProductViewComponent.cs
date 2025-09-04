using BT_Day03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BT_Day03.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
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

