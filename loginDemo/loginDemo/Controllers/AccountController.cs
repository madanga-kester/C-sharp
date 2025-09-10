using Microsoft.AspNetCore.Mvc;
using LoginDemo.Models;

namespace LoginDemo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (user.Username == "admin" && user.Password == "1234")
            {
                return RedirectToAction("Welcome");
            }
            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
