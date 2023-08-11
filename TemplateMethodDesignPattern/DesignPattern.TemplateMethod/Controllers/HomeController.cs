using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
