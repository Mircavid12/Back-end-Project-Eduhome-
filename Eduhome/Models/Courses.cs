using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Courses
    {
        public int id { get; set; }
        [Required,StringLength(100)]
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
        public CourseFeatures CourseFeatures { get; set; }

    }
}
