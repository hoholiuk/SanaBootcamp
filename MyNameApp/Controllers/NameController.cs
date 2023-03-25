using Microsoft.AspNetCore.Mvc;

namespace MyNameApp.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Enter()
        {
            return View();
        }

        public IActionResult Show(string name = "User")
        {
            ViewData["name"] = name;
            return View();
        }
    }
}
