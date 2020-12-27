using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eduhome.Models;
using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Eduhome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM 
            {
                Sliders =_context.Sliders.Where(s=>s.IsDeleted==false).ToList(),
                Bios=_context.Bios.ToList(),
                NoticeBoards=_context.NoticeBoards.Where(nb=>nb.IsDeleted==false).ToList(),
                SingleNoticeRights=_context.SingleNoticeRights.Where(sn=>sn.IsDeleted==false).ToList(),
                Chooses=_context.Chooses.FirstOrDefault(),
                CourseDetails=_context.CourseDetails.Include(cd=>cd.Categories).FirstOrDefault(),
                CourseFeatures=_context.CourseFeatures.FirstOrDefault(),
                Courses=_context.Courses.Where(c=>c.IsDeleted==false).ToList()
            };

            return View(homeVM);
        }

    }
}
