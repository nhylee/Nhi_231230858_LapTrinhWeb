using Microsoft.AspNetCore.Mvc;

namespace BTap1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Customers = new List<string>
            {
                "Le Thi Yen Nhi",
                "Nguyen Thanh Hoang",
                "Le Thi Thanh Tra"
            };
            return View();
        }
        public IActionResult Profile() 
        {
            ViewBag.Customer = new
            {
                Id = 1,
                Name = "Nguyen Thanh Hoang",
                Email = "a@gmail.com"
            };
            return View();  
        }    
    }
}
