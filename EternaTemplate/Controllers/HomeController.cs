using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
