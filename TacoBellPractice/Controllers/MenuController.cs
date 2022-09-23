using Microsoft.AspNetCore.Mvc;
using TacoBellPractice.Models;

namespace TacoBellPractice.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItemForm()
        {
            return View();
        }

        public IActionResult AddedItem(MenuItem itemAdded)
        {
            return View(itemAdded);
        }

    }
}
