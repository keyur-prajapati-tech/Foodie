using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers.Admin
{
    public class ManageOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
