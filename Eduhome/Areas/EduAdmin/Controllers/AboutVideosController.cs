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
    public class AboutVideosController : Controller
    {
        private readonly AppDbContext _context;

        public AboutVideosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/AboutVideos
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutVideos.ToListAsync());
        }

        // GET: EduAdmin/AboutVideos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutVideo = await _context.AboutVideos
                .FirstOrDefaultAsync(m => m.id == id);
            if (aboutVideo == null)
            {
                return NotFound();
            }

            return View(aboutVideo);
        }

        

        // GET: EduAdmin/AboutVideos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutVideo = await _context.AboutVideos.FindAsync(id);
            if (aboutVideo == null)
            {
                return NotFound();
            }
            return View(aboutVideo);
        }

        // POST: EduAdmin/AboutVideos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Video")] AboutVideo aboutVideo)
        {
            if (id != aboutVideo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutVideo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutVideoExists(aboutVideo.id))
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
            return View(aboutVideo);
        }


        private bool AboutVideoExists(int id)
        {
            return _context.AboutVideos.Any(e => e.id == id);
        }
    }
}
