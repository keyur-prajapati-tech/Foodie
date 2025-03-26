using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers.Restaurant
{
    public class OrderHistory : Controller
    {
        public IActionResult History()
        {
            return View();
        }
    }
}
