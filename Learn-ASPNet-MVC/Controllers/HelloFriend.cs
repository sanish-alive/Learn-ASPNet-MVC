using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Learn_ASPNet_MVC.Controllers
{
    public class HelloFriend : Controller
    {
        // GET: /HelloFriend
        public IActionResult Index()
        {
            return View();
        }

        // GET: /hellofriend/friend
        public IActionResult Friend()
        {
            return View("hoho");
        }

        // GET: /hellofriend/information?name=ram&age=21
        public string Information(string name, int age = 18)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Age is {age}...");
        }

        // GET: /hellofriend/testing/23
        public string Testing(int id)
        {
            return $"testing {id}";
        }
    }
}
