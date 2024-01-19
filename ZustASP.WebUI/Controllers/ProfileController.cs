using Microsoft.AspNetCore.Mvc;

namespace ZustASP.WebUI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
