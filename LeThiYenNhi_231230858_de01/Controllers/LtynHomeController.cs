using System.Diagnostics;
using LeThiYenNhi_231230858_de01.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeThiYenNhi_231230858_de01.Controllers
{
    public class LtynHomeController : Controller
    {
        private readonly ILogger<LtynHomeController> _logger;

        public LtynHomeController(ILogger<LtynHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult ltynIndex()
        {
            return View("ltynIndex");
        }

        public IActionResult ltynPrivacy()
        {
            return View("ltynPrivacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ltynError()
        {
            return View("ltynError");
        }
        public IActionResult LtynContact()
        {
            return View();
        }
    }
}
