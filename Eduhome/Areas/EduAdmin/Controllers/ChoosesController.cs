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
    public class ChoosesController : Controller
    {
        private readonly AppDbContext _context;

        public ChoosesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/Chooses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chooses.ToListAsync());
        }
        #region Detail
        // GET: EduAdmin/Chooses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chooses = await _context.Chooses
                .FirstOrDefaultAsync(m => m.id == id);
            if (chooses == null)
            {
                return NotFound();
            }

            return View(chooses);
        }
        #endregion

        #region Update
        // GET: EduAdmin/Chooses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chooses = await _context.Chooses.FindAsync(id);
            if (chooses == null)
            {
                return NotFound();
            }
            return View(chooses);
        }

        // POST: EduAdmin/Chooses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Title,Description1,Description2")] Chooses chooses)
        {
            if (id != chooses.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chooses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChoosesExists(chooses.id))
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
            return View(chooses);
        }
        #endregion



        private bool ChoosesExists(int id)
        {
            return _context.Chooses.Any(e => e.id == id);
        }
    }
}
