using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Skills
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
        public virtual TeacherDetails TeacherDetails { get; set; }
        public int TeacherDetailsId { get; set; }
    }
}
