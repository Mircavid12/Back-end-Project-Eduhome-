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
    public class TagsController : Controller
    {
        private readonly AppDbContext _context;

        public TagsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/Tags
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Tags.Include(t => t.Blogs).Include(t => t.Courses).Include(t => t.Events);
            return View(await appDbContext.ToListAsync());
        }
        #region Detail
        // GET: EduAdmin/Tags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tags = await _context.Tags
                .Include(t => t.Blogs)
                .Include(t => t.Courses)
                .Include(t => t.Events)
                .FirstOrDefaultAsync(m => m.id == id);
            if (tags == null)
            {
                return NotFound();
            }

            return View(tags);
        }
        #endregion

        #region Create
        // GET: EduAdmin/Tags/Create
        public IActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description");
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image");
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image");
            return View();
        }

        // POST: EduAdmin/Tags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Title,IsDeleted,CourseId,EventId,BlogId")] Tags tags)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tags);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description", tags.BlogId);
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image", tags.CourseId);
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image", tags.EventId);
            return View(tags);
        }

        #endregion

        #region Update
        // GET: EduAdmin/Tags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tags = await _context.Tags.FindAsync(id);
            if (tags == null)
            {
                return NotFound();
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description", tags.BlogId);
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image", tags.CourseId);
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image", tags.EventId);
            return View(tags);
        }

        // POST: EduAdmin/Tags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Title,IsDeleted,CourseId,EventId,BlogId")] Tags tags)
        {
            if (id != tags.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tags);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TagsExists(tags.id))
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
            ViewData["BlogId"] = new SelectList(_context.Blogs, "id", "Description", tags.BlogId);
            ViewData["CourseId"] = new SelectList(_context.Courses, "id", "Image", tags.CourseId);
            ViewData["EventId"] = new SelectList(_context.Events, "id", "Image", tags.EventId);
            return View(tags);
        }

        #endregion

        #region MyRegion
        // GET: EduAdmin/Tags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tags = await _context.Tags
                .Include(t => t.Blogs)
                .Include(t => t.Courses)
                .Include(t => t.Events)
                .FirstOrDefaultAsync(m => m.id == id);
            if (tags == null)
            {
                return NotFound();
            }

            return View(tags);
        }

        // POST: EduAdmin/Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tags = await _context.Tags.FindAsync(id);
            _context.Tags.Remove(tags);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        private bool TagsExists(int id)
        {
            return _context.Tags.Any(e => e.id == id);
        }
    }
}
