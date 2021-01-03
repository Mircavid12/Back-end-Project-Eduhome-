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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Teachers.Where(t => t.IsDeleted == false).OrderByDescending(t => t.id).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teachers teachers)
        {
            //if (!ModelState.IsValid)
            //{
            //    return NotFound();
            //}
            bool IsExist = _context.Teachers.Where(t => t.IsDeleted == false).Any(td => td.Name.ToLower() == teachers.Name.ToLower());
            if (IsExist)
            {
                ModelState.AddModelError("Title", "This teacher is already exist");
                return View();
            }
            if (teachers.Photo == null)
            {
                ModelState.AddModelError("", "Please add image");
                return View();
            }
            if (!teachers.Photo.IsImage())
            {
                ModelState.AddModelError("", "Please select image type");
                return View();
            }
            if (!teachers.Photo.MaxSize(250))
            {
                ModelState.AddModelError("", "Image size must be less than 250kb");
                return View();
            }
            string folder = Path.Combine("assets", "img", "teacher");
            string fileName = await teachers.Photo.SaveImageAsync(_env.WebRootPath, folder);
            teachers.Image = fileName;
            teachers.IsDeleted = false;

            await _context.Teachers.AddAsync(teachers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Teachers teachers = _context.Teachers.Where(t => t.IsDeleted == false).Include(t => t.TeacherDetails).Include(tb => tb.TeacherBios).Include(ts => ts.TeacherSkills).FirstOrDefault(t => t.id == id);
            if (teachers == null) return NotFound();
            return View(teachers);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Teachers teachers = _context.Teachers.FirstOrDefault(t => t.id == id && t.IsDeleted == false);
            if (teachers == null) return NotFound();
            return View(teachers);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteTeacher(int? id)
        {
            if (id == null) return NotFound();
            Teachers teachers = _context.Teachers.FirstOrDefault(t => t.id == id && t.IsDeleted == false);
            if (teachers == null) return NotFound();
            teachers.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Teachers teachers = _context.Teachers.Include(t => t.TeacherDetails).Include(tb => tb.TeacherBios).Include(ts => ts.TeacherSkills).FirstOrDefault(t => t.id == id && t.IsDeleted == false);
            if (teachers == null) return NotFound();
            return View(teachers);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Teachers teachers, int? id)
        {
            Teachers viewTeacher = _context.Teachers.Include(td => td.TeacherDetails).Include(tb => tb.TeacherBios).Include(ts => ts.TeacherSkills)
                   .FirstOrDefault(t => t.id == id && t.IsDeleted == false);
            
            if (teachers.Photo != null)
            {
                if (!teachers.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Please select image type");
                    return View(viewTeacher);
                }
                if (!teachers.Photo.MaxSize(250))
                {
                    ModelState.AddModelError("", "Image size must be less than 250kb");
                    return View(viewTeacher);
                }

                string folder = Path.Combine("assets", "img", "teacher");
                string fileName = await teachers.Photo.SaveImageAsync(_env.WebRootPath, folder);
                viewTeacher.Image = fileName;
            }
            viewTeacher.Name = teachers.Name;
            teachers.IsDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
