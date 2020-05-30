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

namespace ELearningApp.Controllers
{
    public class SchoolsController : Controller
    {
        private readonly SchoolService _schoolService;
        public SchoolsController(SchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        //All Schools
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> AllSchools()
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

        //GET School
        [AllowAnonymous]
        public ViewResult GetSchool() => View();
        [HttpGet]
        public async Task<IActionResult> GetSchool(string id)
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

        // CREATE School
        public ViewResult CreateSchool() => View();
        [HttpPost]
        public async Task<IActionResult> CreateSchool(School school)
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

        //UPDATE School
        //GET
        public async Task<IActionResult> UpdateSchool(string id)
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
        //UPDATE School
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateSchool([FromForm] string id, School school)
        {
            _schoolService.Update(id, school);

            return RedirectToAction("AllSchools", "Schools");
        }

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