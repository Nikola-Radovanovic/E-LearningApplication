using ELearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.ViewModels
{
    public class SchoolCourseViewModel
    {
        public School School { get; set; }

        //public Course Course { get; set; }

        public IEnumerable<Course> Course { get; set; }
    }
}
