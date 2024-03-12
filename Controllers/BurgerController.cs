using Microsoft.AspNetCore.Mvc;

namespace MVCFactoryBurger.Controllers
{
    public class BurgerController : Controller
    {

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


        public IActionResult burgerSearch()
        {

            BurgerFactory bf = new BurgerFactory();

            string btype = HomeController.burgerType;

            if (btype.ToLower().Equals("plain"))
            {
                IBurger plainBurger = bf.getBurger("plain");
                ViewBag.Burger = plainBurger;
                ViewBag.BurgerType = "Plain Burger";
            }
            else if (btype.ToLower().Equals("chicken"))
            {
                IBurger chickenBurger = bf.getBurger("chicken");
                ViewBag.Burger = chickenBurger;
                ViewBag.BurgerType = "Chicken Burger";
            }
            else if (btype.ToLower().Equals("cheese"))
            {
                IBurger cheeseBurger = bf.getBurger("cheese");
                ViewBag.Burger = cheeseBurger;
                ViewBag.BurgerType = "Cheese Burger";
            }
            else if (btype.ToLower().Equals("fish"))
            {
                IBurger fishBurger = bf.getBurger("fish");
                ViewBag.Burger = fishBurger;
                ViewBag.BurgerType = "Fish Burger";
            }

            return View();
        }

    }
}
