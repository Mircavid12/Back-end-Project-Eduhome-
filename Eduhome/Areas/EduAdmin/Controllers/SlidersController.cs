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
    public class SlidersController : Controller
    {
        private readonly AppDbContext _context;

        public SlidersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/Sliders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sliders.ToListAsync());
        }
        #region Detail
        // GET: EduAdmin/Sliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliders = await _context.Sliders
                .FirstOrDefaultAsync(m => m.id == id);
            if (sliders == null)
            {
                return NotFound();
            }

            return View(sliders);
        }
        #endregion

        #region Create
        // GET: EduAdmin/Sliders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EduAdmin/Sliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Title1,Title2,Description,Image,IsDeleted")] Sliders sliders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sliders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sliders);
        }

        #endregion

        #region Update
        // GET: EduAdmin/Sliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliders = await _context.Sliders.FindAsync(id);
            if (sliders == null)
            {
                return NotFound();
            }
            return View(sliders);
        }

        // POST: EduAdmin/Sliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Title1,Title2,Description,Image,IsDeleted")] Sliders sliders)
        {
            if (id != sliders.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sliders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlidersExists(sliders.id))
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
            return View(sliders);
        }

        #endregion

        #region Delete
        // GET: EduAdmin/Sliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sliders = await _context.Sliders
                .FirstOrDefaultAsync(m => m.id == id);
            if (sliders == null)
            {
                return NotFound();
            }

            return View(sliders);
        }

        // POST: EduAdmin/Sliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sliders = await _context.Sliders.FindAsync(id);
            _context.Sliders.Remove(sliders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #endregion
        private bool SlidersExists(int id)
        {
            return _context.Sliders.Any(e => e.id == id);
        }
    }
}
