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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Blogs.Where(b => b.IsDeleted == false).OrderByDescending(b => b.id).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blogs blogs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return NotFound();
            //}
            bool IsExist = _context.Blogs.Where(b => b.IsDeleted == false).Any(bd => bd.Description.ToLower() == blogs.Description.ToLower());
            if (IsExist)
            {
                ModelState.AddModelError("Title", "This blog is already exist");
                return View();
            }
            if (blogs.Photo == null)
            {
                ModelState.AddModelError("", "Please add image");
                return View();
            }
            if (!blogs.Photo.IsImage())
            {
                ModelState.AddModelError("", "Please select image type");
                return View();
            }
            if (!blogs.Photo.MaxSize(200))
            {
                ModelState.AddModelError("", "Image size must be less than 200kb");
                return View();
            }
            string folder = Path.Combine("assets", "img", "blog");
            string fileName = await blogs.Photo.SaveImageAsync(_env.WebRootPath, folder);
            blogs.Image = fileName;
            blogs.IsDeleted = false;

            await _context.Blogs.AddAsync(blogs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Blogs blogs = _context.Blogs.Where(b => b.IsDeleted == false).Include(b => b.BlogDetails).Include(bt => bt.Tags).FirstOrDefault(b => b.id == id);
            if (blogs == null) return NotFound();
            return View(blogs);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Blogs blogs = _context.Blogs.FirstOrDefault(b => b.id == id && b.IsDeleted == false);
            if (blogs == null) return NotFound();
            return View(blogs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int? id)
        {
            if (id == null) return NotFound();
            Blogs blogs = _context.Blogs.FirstOrDefault(b => b.id == id && b.IsDeleted == false);
            if (blogs == null) return NotFound();
            blogs.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Blogs blogs = _context.Blogs.Include(b => b.Tags).Include(b => b.latestPosts).Include(b => b.BlogDetails).FirstOrDefault(b => b.id == id && b.IsDeleted == false);
            if (blogs == null) return NotFound();
            return View(blogs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Blogs blogs, int? id)
        {
            Blogs viewBlog = _context.Blogs.Include(b => b.Tags).Include(b => b.latestPosts)
                   .FirstOrDefault(b => b.id == id && b.IsDeleted == false);

            if (blogs.Photo != null)
            {
                if (!blogs.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Please select image type");
                    return View(viewBlog);
                }
                if (!blogs.Photo.MaxSize(250))
                {
                    ModelState.AddModelError("", "Image size must be less than 250kb");
                    return View(viewBlog);
                }

                string folder = Path.Combine("assets", "img", "blog");
                string fileName = await blogs.Photo.SaveImageAsync(_env.WebRootPath, folder);
                viewBlog.Image = fileName;
            }
            viewBlog.Description = blogs.Description;
            blogs.IsDeleted = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
