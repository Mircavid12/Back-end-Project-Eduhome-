using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class CourseVM
    {
        public List<Courses> Courses { get; set; }
        public List<CourseFeatures> CourseFeatures { get; set; }
        public List<Categories> Categories { get; set; }
        public List<LatestPosts> LatestPosts { get; set; }
        public List<Tags> Tags { get; set; }
    }
}
