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
    public class NoticeBoardsController : Controller
    {
        private readonly AppDbContext _context;

        public NoticeBoardsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EduAdmin/NoticeBoards
        public async Task<IActionResult> Index()
        {
            return View(await _context.NoticeBoards.ToListAsync());
        }

        // GET: EduAdmin/NoticeBoards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeBoards = await _context.NoticeBoards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticeBoards == null)
            {
                return NotFound();
            }

            return View(noticeBoards);
        }

        // GET: EduAdmin/NoticeBoards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EduAdmin/NoticeBoards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NoticeTime,Description,IsDeleted")] NoticeBoards noticeBoards)
        {
            if (ModelState.IsValid)
            {
                _context.Add(noticeBoards);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(noticeBoards);
        }

        // GET: EduAdmin/NoticeBoards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeBoards = await _context.NoticeBoards.FindAsync(id);
            if (noticeBoards == null)
            {
                return NotFound();
            }
            return View(noticeBoards);
        }

        // POST: EduAdmin/NoticeBoards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NoticeTime,Description,IsDeleted")] NoticeBoards noticeBoards)
        {
            if (id != noticeBoards.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noticeBoards);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticeBoardsExists(noticeBoards.Id))
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
            return View(noticeBoards);
        }

        // GET: EduAdmin/NoticeBoards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeBoards = await _context.NoticeBoards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticeBoards == null)
            {
                return NotFound();
            }

            return View(noticeBoards);
        }

        // POST: EduAdmin/NoticeBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noticeBoards = await _context.NoticeBoards.FindAsync(id);
            _context.NoticeBoards.Remove(noticeBoards);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticeBoardsExists(int id)
        {
            return _context.NoticeBoards.Any(e => e.Id == id);
        }
    }
}
