using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearningApp.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserService _userService;

        public IActionResult Index()
        {
            return View();
        }
    }
}