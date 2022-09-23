using CoffeeShopRegLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopRegLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        //Replaced this by adding a class for User
        //public IActionResult ProcessRegister(string firstName, string email)
        //{
        //    ViewBag.FirstName = firstName;
        //    ViewBag.Email = email;rtt
        //    return View();
        //}

        public IActionResult ProcessRegister(User newuser)
        {
            //This coule really be replaced now by putting "required" in form in put.
            if (newuser.FirstName == null || newuser.LastName == null || newuser.Email == null || newuser.Password == null)
            {
                return View("ErrorNull");
            }
            else if (newuser.Password == newuser.ConfirmPass)
            {
                return View(newuser);
            }

            //else
            //{
            //    return View("ErrorPassword");
            //}
            else
            {
                ViewBag.PasswordError = "Passwords do not match! Please try again.";
                return View("Register");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}