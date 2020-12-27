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
        public List<Events> Events { get; set; }
        public Testimonials Testimonials { get; set; }
        public List<Blogs> Blogs { get; set; }
    }
}
