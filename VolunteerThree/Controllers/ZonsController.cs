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
    public class ZonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Zons
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Zons.Include(z => z.Reg);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Zons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zon = await _context.Zons
                .Include(z => z.Reg)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zon == null)
            {
                return NotFound();
            }

            return View(zon);
        }

        // GET: Zons/Create
        public IActionResult Create()
        {
            ViewData["RegId"] = new SelectList(_context.Regs, "Id", "Id");
            return View();
        }

        // POST: Zons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ZName,RegId")] Zon zon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RegId"] = new SelectList(_context.Regs, "Id", "Id", zon.RegId);
            return View(zon);
        }

        // GET: Zons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zon = await _context.Zons.FindAsync(id);
            if (zon == null)
            {
                return NotFound();
            }
            ViewData["RegId"] = new SelectList(_context.Regs, "Id", "Id", zon.RegId);
            return View(zon);
        }

        // POST: Zons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ZName,RegId")] Zon zon)
        {
            if (id != zon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZonExists(zon.Id))
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
            ViewData["RegId"] = new SelectList(_context.Regs, "Id", "Id", zon.RegId);
            return View(zon);
        }

        // GET: Zons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zon = await _context.Zons
                .Include(z => z.Reg)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zon == null)
            {
                return NotFound();
            }

            return View(zon);
        }

        // POST: Zons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zon = await _context.Zons.FindAsync(id);
            _context.Zons.Remove(zon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZonExists(int id)
        {
            return _context.Zons.Any(e => e.Id == id);
        }
    }
}
