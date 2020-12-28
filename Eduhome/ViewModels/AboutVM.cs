using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class AboutVM
    {
        public AboutIntro AboutIntro { get; set; }
        public List<Teachers> Teachers { get; set; }
        public List<TeacherDetails> TeacherDetails { get; set; }
        public List<TeacherBios> teacherBios { get; set; }
        public List<Skills> Skills { get; set; }
        public List<ContactInfos> ContactInfos { get; set; }
        public List<TeacherBios> TeacherBios { get; set; }
        public Testimonials Testimonials { get; set; }
        public AboutVideo AboutVideo { get; set; }
        public List<NoticeBoards> NoticeBoards { get; set; }
    }
}
