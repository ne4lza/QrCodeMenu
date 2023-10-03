using Microsoft.AspNetCore.Mvc;

namespace QrCodeMenu.Web.Areas.User.Controllers
{
    [Area("user")]
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
