using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class ContactInfos
    {
        public int id { get; set; }
        public string Mail { get; set; }
        public string Number { get; set; }
        public string Skype { get; set; }
        public virtual TeacherDetails TeacherDetails { get; set; }
        public int TeacherDetailsId { get; set; }
    }
}
