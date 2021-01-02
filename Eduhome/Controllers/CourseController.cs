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
            //coursevm coursevm = new coursevm
            //{
            //    coursefeatures=_context.coursefeatures.tolist(),
            //    categories=_context.categories.where(c=>c.isdeleted==false).tolist(),
            //    latestposts=_context.latestposts.where(l=>l.isdeleted==false).tolist(),
            //    tags=_context.tags.where(t=>t.isdeleted==false).tolist()
            //};
            Courses courses = _context.Courses.Where(cs => cs.IsDeleted == false).Include(ct=>ct.Tags).Include(cp => cp.LatestPosts).Include(cf => cf.CourseFeatures).FirstOrDefault(c => c.id == id);
            if (courses==null)
            {
                return NotFound();
            }
            return View(courses);
        }
    }
}
