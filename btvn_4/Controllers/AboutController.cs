using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class AboutController : Controller
    {


        // Action cho URL: /About/About
        public IActionResult About()
        {
            return View(); // Tìm view: Views/About/About.cshtml
        }
    }
}
