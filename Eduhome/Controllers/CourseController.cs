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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseVM courseVM = new CourseVM 
            { 
                Courses=_context.Courses.Where(c=>c.IsDeleted==false).ToList(),
            };

            return View(courseVM);
        }
        public IActionResult CourseDetail()
        {
            CourseVM courseVM = new CourseVM
            {
                CourseFeatures=_context.CourseFeatures.ToList(),
                Categories=_context.Categories.Where(c=>c.IsDeleted==false).ToList(),
                LatestPosts=_context.LatestPosts.Where(l=>l.IsDeleted==false).ToList(),
                Tags=_context.Tags.Where(t=>t.IsDeleted==false).ToList()
            };
            return View(courseVM);
        }
    }
}
