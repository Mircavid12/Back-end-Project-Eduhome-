using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class CourseFeatures
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string Level { get; set; }
        public string Language { get; set; }
        public string StudentsCount { get; set; }
        public string Assestments { get; set; }
        public double CourseFee { get; set; }
    }
}
