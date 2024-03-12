using Microsoft.AspNetCore.Mvc;
using MVCFactoryBurger.Models;
using System.Diagnostics;

namespace MVCFactoryBurger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static string burgerType;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SearchBurger()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchBurger(string input)
        {
            BurgerFactory bf  = new BurgerFactory();

            burgerType = input;
            return RedirectToAction("burgerSearch", "Burger");

        }
        public IActionResult burgerView()
        {

            BurgerFactory bf = new BurgerFactory();

            IBurger plainBurger = bf.getBurger("plain");
            IBurger chickenBurger = bf.getBurger("chicken");
            IBurger cheeseBurger = bf.getBurger("cheese");
            IBurger fishBurger = bf.getBurger("fish");

            ViewBag.PlainBurger = plainBurger;
            ViewBag.ChickenBurger = chickenBurger;
            ViewBag.CheeseBurger = cheeseBurger;
            ViewBag.FishBurger = fishBurger;

            return View();
        }
        public JsonResult LoadShit() 
        {
            var shit = "Yip, you've just loaded some shit";
            return Json(shit);
        }
    }
}
