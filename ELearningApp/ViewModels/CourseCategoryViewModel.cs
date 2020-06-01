using ELearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.ViewModels
{
    public class CourseCategoryViewModel
    {
        public IEnumerable<Category> CategoryArray { get; set; }
        public Category Category { get; set; }
        public Course Course { get; set; }
        public IEnumerable<School> SchoolArray { get; set; }
        public School School { get; set; }
    }
}
