using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using System.Threading.Tasks;
using Foodie.Models;
using Foodie.Repositories;
using Microsoft.Extensions.Configuration;

namespace Foodie.Controllers.DeliveryPartner
{
    [Route("deliverysignup")]
    public class DeliverSignup : Controller
    {
        

        // 🎯 Delivery Partner Index Page
        [Route("d/index")]
        public IActionResult DeliveryIndex()
        {
            return View("~/Views/DeliverSignup/DeliveryIndex.cshtml");
        }

        [Route("d/regi")]
        public async Task<IActionResult> DeliveryRegister()
        {
            return View();
        }

        // 🎯 Delivery Partner Login
        [Route("D/LOGIN")]
        public IActionResult DeliveryLogin()
        {
            return View("~/Views/DeliverSignup/DeliveryLogin.cshtml");
        }

      


        // 🎯 Pending Approval Page
        [Route("d/pending")]
        public IActionResult PendingApproval()
        {
            return View("~/Views/DeliverSignup/PendingApproval.cshtml");
        }

        // 🎯 Additional Details Page
        [Route("d/details")]
        public IActionResult Per_Details()
        {
            return View("~/Views/DeliverSignup/Per_Details.cshtml");
        }

        // 🎯 Vehicle Details Page
        [Route("d/vehicle")]
        public IActionResult VehicleDetails()
        {
            return View();
        }

        // 🎯 Document Upload Page
        [Route("d/doc")]
        public IActionResult Document()
        {
            return View();
        }

        // 🎯 Dashboard Page
        [Route("d/dash")]
        public IActionResult Dashboard()
        {
            return View();
        }

        // 🎯 Time Slot Management Page
        [Route("d/slots")]
        public IActionResult TimeSlot()
        {
            return View();
        }

        // 🎯 Support Page
        [Route("d/support")]
        public IActionResult Support()
        {
            return View();
        }

        // 🎯 Profile Management Page
        [Route("d/profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
