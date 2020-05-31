using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ELearningApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ELearningApp.API.Services;
using Microsoft.AspNetCore.Authorization;
using ELearningApp.ViewModels;

namespace ELearningApp.Controllers
{
    [Authorize(Roles = "Admin, User")]
    public class SchoolsController : Controller
    {
        private readonly SchoolService _schoolService;
        private readonly CourseService _courseService;
        public SchoolsController(SchoolService schoolService, CourseService courseService)
        {
            _schoolService = schoolService;
            _courseService = courseService;
        }

        //All Schools
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AllSchools()
        {
            try
            {
                List<School> schoolsList = new List<School>();

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44345/api/Schools"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        schoolsList = JsonConvert.DeserializeObject<List<School>>(apiResponse);
                    }
                }

                return View(schoolsList);
            }
            catch
            {
                return NotFound();
            }
        }

        //GET School
        [Authorize]
        public ViewResult GetSchool() => View();
        [HttpGet]
        public IActionResult GetSchool(string id)
        {
            try
            {  
                SchoolCourseViewModel viewModel = new SchoolCourseViewModel
                {
                    School = _schoolService.Get(id),
                    Course = _courseService.Get().ToList()
                }; 

                return View(viewModel);
            }
            catch
            {
                return NotFound();
            }

        }
        [Authorize(Roles ="Admin")]
        // CREATE School
        public ViewResult CreateSchool() => View();
        [HttpPost]
        public async Task<IActionResult> CreateSchool(School school)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                School returnedSchool = new School();

                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(school), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://localhost:44345/api/Schools", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        returnedSchool = JsonConvert.DeserializeObject<School>(apiResponse);
                    }
                }
                return RedirectToAction("AllSchools", "Schools", returnedSchool);
        }
            catch
            {
                return NotFound();
    }
}
        [Authorize(Roles = "Admin")]
        //UPDATE School
        //GET
        public async Task<IActionResult> UpdateSchool(string id)
        {
            try
            {
                School school = new School();

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://localhost:44345/api/Schools/" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        school = JsonConvert.DeserializeObject<School>(apiResponse);
                    }
                }
                return View(school);
            }
            catch
            {
                return NotFound();
            }
        }
        //UPDATE School
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateSchool([FromForm] string id, School school)
        {
            try
            {
                _schoolService.Update(id, school);
                return RedirectToAction("AllSchools", "Schools");
            }
            catch
            {
                return NotFound();
            }
        }

        [Authorize(Roles = "Admin")]
        //DELETE School
        //GET
        public IActionResult DeleteSchool(string id)
        {
            try
            {
                var school = _schoolService.Get(id);

                if (school == null)
                {
                    return NotFound();
                }

                return View(school);
            }
            catch
            {
                return View();
            }
        }

        //DELETE School
        //POST
        [HttpPost, ActionName("DeleteSchool")]
        public IActionResult DeleteSchoolConfirm(string id)
        {
            try
            {
                var getSchoolId = _schoolService.Get(id);

                if (getSchoolId == null)
                {
                    return NotFound();
                }

                _schoolService.Remove(getSchoolId.Id);

                return RedirectToAction("AllSchools");
            }
            catch
            {
                return NoContent();
            }
        }
    }
}