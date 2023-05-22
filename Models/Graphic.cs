using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Models
{
    public class Graphic : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
