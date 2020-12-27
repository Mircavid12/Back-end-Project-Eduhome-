using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Categories
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int CourseDetailId { get; set; }
        public virtual CourseDetails CourseDetails { get; set; }
    }
}
