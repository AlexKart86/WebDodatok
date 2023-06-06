using Microsoft.AspNetCore.Mvc;

namespace Karpaty.Controllers
{
    public class AdminController: Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
