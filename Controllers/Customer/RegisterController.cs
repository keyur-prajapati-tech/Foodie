using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers.Customer
{
    public class RegisterController : Controller
    {
        public IActionResult CustomerRegister()
        {
            return View();
        }
    }
}
