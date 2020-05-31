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
        public async Task<IActionResult> Login(User model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var isValid = true; // TODO Validate the username and the password with your own logic
                if (!isValid)
                {
                    ModelState.AddModelError("", "Username or password is invalid");
                    return View();
                }
            }

            if (LoginUser(model.Email, model.Password))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Email)
                };
                //var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Profile");
            }

            if (!string.IsNullOrEmpty(ReturnUrl)) // Povratak na trazenu stranu posle autentikacije
            {
                return Redirect(ReturnUrl);
            }
            else
            {
                return View();
            }
            
        }

        private bool LoginUser(string username, string password)
        {
            return true;
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
            
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