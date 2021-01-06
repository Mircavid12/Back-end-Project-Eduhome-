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
    public class AboutIntroesController : Controller
    {
        private readonly AppDbContext _context;

        public AboutIntroesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/AboutIntroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutIntros.ToListAsync());
        }
        #region Detail
        // GET: EduAdmin/AboutIntroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutIntro = await _context.AboutIntros
                .FirstOrDefaultAsync(m => m.id == id);
            if (aboutIntro == null)
            {
                return NotFound();
            }

            return View(aboutIntro);
        }
        #endregion

        #region Update
        // GET: EduAdmin/AboutIntroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutIntro = await _context.AboutIntros.FindAsync(id);
            if (aboutIntro == null)
            {
                return NotFound();
            }
            return View(aboutIntro);
        }

        // POST: EduAdmin/AboutIntroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Title,Image,Description1,Description2")] AboutIntro aboutIntro)
        {
            if (id != aboutIntro.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutIntro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutIntroExists(aboutIntro.id))
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
            return View(aboutIntro);
        }

        #endregion

        private bool AboutIntroExists(int id)
        {
            return _context.AboutIntros.Any(e => e.id == id);
        }
    }
}
