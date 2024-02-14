using Microsoft.AspNetCore.Mvc;

namespace SG1.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
    }
}
