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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Blogs.Where(t => t.IsDeleted == false).Count() / 3);
            ViewBag.page = page;
            if (page == null)
            {
                List<Blogs> blogs = _context.Blogs.Where(t => t.IsDeleted == false).Take(3).ToList();
                return View(blogs);
            }
            List<Blogs> blogs1 = _context.Blogs.Where(t => t.IsDeleted == false).Skip((int)(page - 1) * 3).Take(3).ToList();
            return View(blogs1);
        }
        public IActionResult BlogDetail(int? id)
        {
            if (id == null)
            {
                return View(_context.Blogs.Where(b => b.IsDeleted == false).Include(b => b.BlogDetails).FirstOrDefault());
            }


            Blogs blogs = _context.Blogs.Where(b => b.IsDeleted == false).Include(et => et.Tags).Include(ep => ep.latestPosts).Include(bd => bd.BlogDetails).FirstOrDefault(b => b.id == id);
            if (blogs == null)
            {
                return NotFound();
            }
            return View(blogs);
        }
    }
}
