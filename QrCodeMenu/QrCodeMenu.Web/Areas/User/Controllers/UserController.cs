using Microsoft.AspNetCore.Mvc;

namespace QrCodeMenu.Web.Areas.User.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
