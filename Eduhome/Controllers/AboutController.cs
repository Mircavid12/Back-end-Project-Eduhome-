using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eduhome.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutVM aboutVM = new AboutVM
            {
                AboutIntro = _context.AboutIntros.FirstOrDefault(),
                Teachers=_context.Teachers.Where(t=>t.IsDeleted==false).Include(t=>t.TeacherBios).ToList(),
                Testimonials=_context.Testimonials.FirstOrDefault(),
                AboutVideo=_context.AboutVideos.FirstOrDefault(),
                NoticeBoards=_context.NoticeBoards.Where(nb=>nb.IsDeleted==false).ToList()
            };
            return View(aboutVM);
        }
    }
}
