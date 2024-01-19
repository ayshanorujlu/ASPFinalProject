using Microsoft.AspNetCore.Mvc;

namespace ZustASP.WebUI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
