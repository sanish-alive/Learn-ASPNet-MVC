using Microsoft.AspNetCore.Mvc;

namespace Learn_ASPNet_MVC.Controllers
{
    public class FandomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NeedFandom()
        {
            return View("needfandom");
        }
    }
}
