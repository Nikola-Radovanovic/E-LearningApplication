using ELearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningApp.ViewModels
{
    public class CourseCategoryViewModel
    {
        public Category[] Categories { get; set; }
        public Category Category { get; set; }
        public Course Course { get; set; }
    }
}
