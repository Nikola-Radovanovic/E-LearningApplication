using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearningApp.Models;
using ELearningApp.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : Controller
    {
        private readonly CourseService _courseService;

        public CoursesController(CourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public ActionResult<List<Course>> Get() =>
            _courseService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCourse")]
        public ActionResult<Course> Get(string id)
        {
            var getCourse = _courseService.Get(id);

            if (getCourse == null)
            {
                return NotFound();
            }

            return getCourse;
        }

        [HttpPost]
        public ActionResult<Course> Create(Course course)
        {
            _courseService.Create(course);

            return CreatedAtRoute("GetCourse", new { id = course.Id.ToString() }, course);
        }

        //[HttpPut("{id:length(24)}")]
        //[ValidateAntiForgeryToken]
        //public IActionResult Update([FromForm] string id, Course course)
        //{
        //    var updateCourse = _courseService.Get(id);

        //    if (updateCourse == null)
        //    {
        //        return NotFound();
        //    }

        //    _courseService.Update(id, course);

        //    return NoContent();
        //}

        //[HttpPatch("{id:length(24)}")]
        //public StatusCodeResult Patch(string id, [FromBody]JsonPatchDocument<Course> patch)
        //{
        //    Course course = _courseService.Get(id);

        //    if (course != null)
        //    {
        //        patch.ApplyTo(course);
        //        return Ok();
        //    }

        //    return NotFound();
        //}

        //[HttpDelete("{id:length(24)}")]
        //public IActionResult Delete(string id)
        //{
        //    var deleteCourse = _courseService.Get(id);

        //    if (deleteCourse == null)
        //    {
        //        return NotFound();
        //    }

        //    _courseService.Remove(id);

        //    return NoContent();
        //}
    }
}