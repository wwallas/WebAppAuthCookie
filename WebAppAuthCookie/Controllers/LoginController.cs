using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebAppAuthCookie.Models;

namespace WebAppAuthCookie.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
            //return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult PerformLogin([Bind] User userdetails)
        {
            if ((!string.IsNullOrEmpty(userdetails.UserId)) && (!string.IsNullOrEmpty(userdetails.Password)))
            {
                if ((userdetails.UserId.Equals("master") && userdetails.Password.Equals("admin")))
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("Index");
        }
    }
}
