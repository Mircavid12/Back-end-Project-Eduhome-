using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.Models;
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
        public IActionResult CourseDetail(int id)
        {
            if (id==null)
            {
                return View(_context.Courses.Where(c=>c.IsDeleted==false).Include(c=>c.CourseFeatures).FirstOrDefault());
            }
            //CourseVM courseVM = new CourseVM
            //{
            //    CourseFeatures=_context.CourseFeatures.ToList(),
            //    Categories=_context.Categories.Where(c=>c.IsDeleted==false).ToList(),
            //    LatestPosts=_context.LatestPosts.Where(l=>l.IsDeleted==false).ToList(),
            //    Tags=_context.Tags.Where(t=>t.IsDeleted==false).ToList()
            //};
            Courses courses = _context.Courses.Where(cs => cs.IsDeleted == false).Include(cf => cf.CourseFeatures).FirstOrDefault(c => c.id == id);
            if (courses==null)
            {
                return NotFound();
            }
            return View(courses);
        }
    }
}
