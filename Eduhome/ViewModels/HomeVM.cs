using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class HomeVM
    {
        public List<Sliders> Sliders { get; set; }
        public List<Bio> Bios { get; set; }
        public List<NoticeBoards> NoticeBoards { get; set; }
        public List<SingleNoticeRight> SingleNoticeRights { get; set; }
        public Chooses Chooses { get; set; }
        public List<Courses> Courses { get; set; }
        public CourseDetails CourseDetails { get; set; }
        public CourseFeatures CourseFeatures { get; set; }
        public List<Categories> Categories { get; set; }
    }
}
