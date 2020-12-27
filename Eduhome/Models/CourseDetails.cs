using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class CourseDetails
    {
        public int id { get; set; }
        public string CoursePurpose { get; set; }
        public string PurposeDescription { get; set; }
        public string CourseDetailTitle1 { get; set; }
        public string Description1 { get; set; }
        public string CourseDetailTitle2 { get; set; }
        public string Description2 { get; set; }
        public string CourseDetailTitle3 { get; set; }
        public string Description3 { get; set; }
        public ICollection<Categories> Categories { get; set; }
    }
}
