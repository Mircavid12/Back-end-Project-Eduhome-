using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eduhome.DAL;
using Eduhome.Models;

namespace Eduhome.Areas.EduAdmin.Controllers
{
    [Area("EduAdmin")]
    public class LatestPostsController : Controller
    {
        private readonly AppDbContext _context;

        public LatestPostsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/LatestPosts
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.LatestPosts.Include(l => l.Blogs).Include(l => l.Courses).Include(l => l.Events);
            return View(await appDbContext.ToListAsync());
        }
        #region Detail
        // GET: EduAdmin/LatestPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var latestPosts = await _context.LatestPosts
                .Include(l => l.Blogs)
                .Include(l => l.Courses)
                .Include(l => l.Events)
                .FirstOrDefaultAsync(m => m.id == id);
            if (latestPosts == null)
            {
                return NotFound();
            }

            return View(latestPosts);
        }
        #endregion

        #region Create
        // GET: EduAdmin/LatestPosts/Create
        public IActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description");
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image");
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image");
            return View();
        }

        // POST: EduAdmin/LatestPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Title,Image,Description,IsDeleted,CourseId,EventId,BlogId")] LatestPosts latestPosts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(latestPosts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description", latestPosts.BlogId);
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image", latestPosts.CourseId);
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image", latestPosts.EventId);
            return View(latestPosts);
        }

        #endregion

        #region Update
        // GET: EduAdmin/LatestPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var latestPosts = await _context.LatestPosts.FindAsync(id);
            if (latestPosts == null)
            {
                return NotFound();
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description", latestPosts.BlogId);
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image", latestPosts.CourseId);
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image", latestPosts.EventId);
            return View(latestPosts);
        }

        // POST: EduAdmin/LatestPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Title,Image,Description,IsDeleted,CourseId,EventId,BlogId")] LatestPosts latestPosts)
        {
            if (id != latestPosts.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(latestPosts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LatestPostsExists(latestPosts.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description", latestPosts.BlogId);
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image", latestPosts.CourseId);
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image", latestPosts.EventId);
            return View(latestPosts);
        }

        #endregion

        #region Delete
        // GET: EduAdmin/LatestPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var latestPosts = await _context.LatestPosts
                .Include(l => l.Blogs)
                .Include(l => l.Courses)
                .Include(l => l.Events)
                .FirstOrDefaultAsync(m => m.id == id);
            if (latestPosts == null)
            {
                return NotFound();
            }

            return View(latestPosts);
        }

        // POST: EduAdmin/LatestPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var latestPosts = await _context.LatestPosts.FindAsync(id);
            _context.LatestPosts.Remove(latestPosts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        private bool LatestPostsExists(int id)
        {
            return _context.LatestPosts.Any(e => e.id == id);
        }
    }
}
