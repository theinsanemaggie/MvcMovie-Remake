using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
