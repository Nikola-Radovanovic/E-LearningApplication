using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ELearningApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([Bind]User user)
        {
            
            if (!string.IsNullOrEmpty(user.Email) && string.IsNullOrEmpty(user.Password))
            {
                return RedirectToAction("NoAccess");
            }

            
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            if (user.Email == "admin@admin.com" && user.Password == "Admin123" )
            {

                //Kreiramo identitet za Rolu "User"
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }
            else
            {
                //Kreiramo identitet za Rolu "User" 
               identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Role, "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }
            if (isAuthenticated)
            {
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Profile");
            }
            return View(); 
        }
    




//[HttpPost]
//public async Task<IActionResult> Login(User user)
//{
//    if (ModelState.IsValid)
//    {
//        var isValid = true; // TODO Validate the username and the password with your own logic
//        if (!isValid)
//        {
//            ModelState.AddModelError("", "Username or password is invalid");
//            return View();
//        }

//    }
//}
//if (LoginUser(user.Email, user.Password))
//{
//    var claims = new List<Claim>
//    {
//        new Claim(ClaimTypes.Name, user.Email)
//    };
//    //var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//    var userIdentity = new ClaimsIdentity(claims, "login");
//    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
//    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
//    return RedirectToAction("Index", "Profile");
//return RedirectToAction("Index", "Home");               //}

        private bool LoginUser(string username, string password)
        {
            return true;
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");

        }
        [HttpGet]
        public IActionResult NoAccess()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}