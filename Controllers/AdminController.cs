using Karpaty.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Authentication;

namespace Karpaty.Controllers
{
    public class AdminController: Controller
    {
        ApplicationContext _context;

        public AdminController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Auth(string UserName, string UserPassword)
        {
            var user = _context.DictAdmins.FirstOrDefault(x => x.UserName == UserName && x.UserPassword == UserPassword);
            if (user == null)
            {
                TempData["error"] = "Не вірний логін або пароль";
                return RedirectToAction("Login");
            }

            var claims = new List<Claim> { new Claim(ClaimTypes.Name, user.UserName) };
            // создаем объект ClaimsIdentity
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return RedirectToAction("Bookings");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Bookings()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }



    }
}
