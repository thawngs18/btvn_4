using Microsoft.AspNetCore.Mvc;

namespace btvn_4.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
