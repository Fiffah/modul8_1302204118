using Microsoft.AspNetCore.Mvc;

namespace modul8_1302204118.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
