using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolunteerThree.Data;
using VolunteerThree.Models;

namespace VolunteerThree.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RegsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Regs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Regs.ToListAsync());
        }

        // GET: Regs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reg = await _context.Regs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reg == null)
            {
                return NotFound();
            }

            return View(reg);
        }

        // GET: Regs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Regs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RName")] Reg reg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reg);
        }

        // GET: Regs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reg = await _context.Regs.FindAsync(id);
            if (reg == null)
            {
                return NotFound();
            }
            return View(reg);
        }

        // POST: Regs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RName")] Reg reg)
        {
            if (id != reg.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegExists(reg.Id))
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
            return View(reg);
        }

        // GET: Regs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reg = await _context.Regs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reg == null)
            {
                return NotFound();
            }

            return View(reg);
        }

        // POST: Regs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reg = await _context.Regs.FindAsync(id);
            _context.Regs.Remove(reg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegExists(int id)
        {
            return _context.Regs.Any(e => e.Id == id);
        }
    }
}
