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
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Courses.Where(c => c.IsDeleted == false).Count() / 3);
            ViewBag.page = page;
            if (page == null)
            {
                List<Courses> courseDetails = _context.Courses.Where(c => c.IsDeleted == false).Take(3).ToList();
                return View(courseDetails);
            }
            List<Courses> courseDetails1 = _context.Courses.Where(t => t.IsDeleted == false).Skip((int)(page - 1) * 3).Take(3).ToList();
            return View(courseDetails1);
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
