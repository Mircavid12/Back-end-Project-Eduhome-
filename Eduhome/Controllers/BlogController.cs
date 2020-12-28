using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogVM blogVM = new BlogVM
            {
                Blogs=_context.Blogs.Where(b=>b.IsDeleted==false).ToList(),
                BlogDetails=_context.BlogDetails.ToList()
            };
            return View(blogVM);
        }
        public IActionResult BlogDetail()
        {
            BlogVM blogVM = new BlogVM
            {
                BlogDetails = _context.BlogDetails.ToList(),
                Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList(),
                LatestPosts = _context.LatestPosts.Where(l => l.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList()
            };
            return View(blogVM);
        }
    }
}
