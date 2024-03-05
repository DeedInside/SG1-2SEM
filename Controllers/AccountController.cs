using Microsoft.AspNetCore.Mvc;

namespace SG1.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Reg(string userName, string userPas)
        {

            return new JsonResult(userName, userPas);
        }
        public IActionResult Reg()
        {
            return View();
        }
    }
}
