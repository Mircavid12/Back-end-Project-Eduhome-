using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class TeacherVM
    {
        public List<Teachers> Teachers { get; set; }
        public List<TeacherBios> TeacherBios { get; set; }
        public List<TeacherDetails> TeacherDetails { get; set; }
        public List<ContactInfos> ContactInfos { get; set; }
        public List<Skills> Skills { get; set; }
    }
}
