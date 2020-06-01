using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ELearningApp.API.Services;
using ELearningApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Text.RegularExpressions;

namespace ELearningApp.Controllers
{
    //[Authorize]
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // GET: Users
        public ActionResult Index()
        {
            try
            {
                return View(_userService.Get());
            }
            catch
            {
                return NotFound();
            }
        }
        
        // GET: Users/Create
        public ActionResult Create()
        {
            try
            {
                return View();
            }
            catch
            {

                return NotFound();
            }
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _userService.Create(user);
                    return RedirectToAction("Login", "Account");
                    
                }
                return View(user);
            }
            catch
            {
                ModelState.AddModelError("", "Niste uspeli da kreirate korisnika!");
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(string id)
        {
            try
            {
            if (id == null)
            {
                return NotFound();
            }

            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View();
            }
            catch
            {
                return NotFound();
            }
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, User user)
        {
            try
            {
                if (id != user.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    _userService.Update(id, user);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(user);
                }
            }
            catch
            {
                return NotFound();
            }
        }
        // GET: Users/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var user = _userService.Get(id);

                if (user == null)
                {
                    return NotFound();
                }

                _userService.Remove(user.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}