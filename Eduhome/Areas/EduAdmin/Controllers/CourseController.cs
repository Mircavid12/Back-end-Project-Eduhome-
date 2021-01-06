using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.Extentions;
using Eduhome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eduhome.Areas.EduAdmin.Controllers
{
    [Area("EduAdmin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Courses.Where(c=>c.IsDeleted==false).OrderByDescending(c=>c.id).ToList());
        }
        #region Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Courses course)
        {
            //if (!ModelState.IsValid)
            //{
            //    return NotFound();
            //}
            bool IsExist = _context.Courses.Where(c => c.IsDeleted == false).Any(cs => cs.Title.ToLower() == course.Title.ToLower());
            if (IsExist)
            {
                ModelState.AddModelError("Title", "This course is already exist");
                return View();
            }
            if (course.Photo == null)
            {
                ModelState.AddModelError("", "Please add image");
                return View();
            }
            if (!course.Photo.IsImage())
            {
                ModelState.AddModelError("", "Please select image type");
                return View();
            }
            if (!course.Photo.MaxSize(200))
            {
                ModelState.AddModelError("", "Image size must be less than 200kb");
                return View();
            }
            string folder = Path.Combine("assets", "img", "course");
            string fileName = await course.Photo.SaveImageAsync(_env.WebRootPath, folder);
            course.Image = fileName;
            course.IsDeleted = false;

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Courses courses = _context.Courses.Where(c => c.IsDeleted == false).Include(c => c.CourseFeatures).Include(ct => ct.Tags).FirstOrDefault(c => c.id == id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Courses courses = _context.Courses.FirstOrDefault(c => c.id == id && c.IsDeleted == false);
            if (courses == null) return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if (id == null) return NotFound();
            Courses courses = _context.Courses.FirstOrDefault(c => c.id == id && c.IsDeleted == false);
            if (courses == null) return NotFound();
            courses.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        #endregion

        #region Update
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Courses courses = _context.Courses.Include(c => c.Tags).Include(c => c.LatestPosts).Include(c => c.CourseFeatures).FirstOrDefault(c => c.id == id && c.IsDeleted == false);
            if (courses == null) return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Courses courses, int? id)
        {
            Courses viewCourse = _context.Courses.Include(p => p.Tags).Include(c => c.LatestPosts)
                   .FirstOrDefault(c => c.id == id && c.IsDeleted == false);

            if (courses.Photo != null)
            {
                if (!courses.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Please select image type");
                    return View(viewCourse);
                }
                if (!courses.Photo.MaxSize(250))
                {
                    ModelState.AddModelError("", "Image size must be less than 250kb");
                    return View(viewCourse);
                }

                string folder = Path.Combine("assets", "img", "course");
                string fileName = await courses.Photo.SaveImageAsync(_env.WebRootPath, folder);
                viewCourse.Image = fileName;
            }
            viewCourse.Title = courses.Title;
            courses.IsDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion



    }
}
