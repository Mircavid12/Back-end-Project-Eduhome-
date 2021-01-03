using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class TeacherSkill
    {
        public int id { get; set; }
        public virtual Teachers Teachers { get; set; }
        public int  TeachersId { get; set; }
        public virtual Skills Skills { get; set; }
        public int SkillsId { get; set; }
        public double? Percentage { get; set; }
    }
}
