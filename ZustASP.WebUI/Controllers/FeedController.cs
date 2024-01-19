using Microsoft.AspNetCore.Mvc;

namespace ZustASP.WebUI.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
