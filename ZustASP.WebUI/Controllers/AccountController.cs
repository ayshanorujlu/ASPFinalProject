using Microsoft.AspNetCore.Mvc;

namespace ZustASP.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
