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
    public class SingleNoticeRightsController : Controller
    {
        private readonly AppDbContext _context;

        public SingleNoticeRightsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/SingleNoticeRights
        public async Task<IActionResult> Index()
        {
            return View(await _context.SingleNoticeRights.ToListAsync());
        }

        // GET: EduAdmin/SingleNoticeRights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singleNoticeRight = await _context.SingleNoticeRights
                .FirstOrDefaultAsync(m => m.id == id);
            if (singleNoticeRight == null)
            {
                return NotFound();
            }

            return View(singleNoticeRight);
        }

        // GET: EduAdmin/SingleNoticeRights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EduAdmin/SingleNoticeRights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Title,Description,IsDeleted")] SingleNoticeRight singleNoticeRight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(singleNoticeRight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(singleNoticeRight);
        }

        // GET: EduAdmin/SingleNoticeRights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singleNoticeRight = await _context.SingleNoticeRights.FindAsync(id);
            if (singleNoticeRight == null)
            {
                return NotFound();
            }
            return View(singleNoticeRight);
        }

        // POST: EduAdmin/SingleNoticeRights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Title,Description,IsDeleted")] SingleNoticeRight singleNoticeRight)
        {
            if (id != singleNoticeRight.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(singleNoticeRight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SingleNoticeRightExists(singleNoticeRight.id))
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
            return View(singleNoticeRight);
        }

        // GET: EduAdmin/SingleNoticeRights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singleNoticeRight = await _context.SingleNoticeRights
                .FirstOrDefaultAsync(m => m.id == id);
            if (singleNoticeRight == null)
            {
                return NotFound();
            }

            return View(singleNoticeRight);
        }

        // POST: EduAdmin/SingleNoticeRights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var singleNoticeRight = await _context.SingleNoticeRights.FindAsync(id);
            _context.SingleNoticeRights.Remove(singleNoticeRight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SingleNoticeRightExists(int id)
        {
            return _context.SingleNoticeRights.Any(e => e.id == id);
        }
    }
}
