using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using VolunteerThree.Data;
using VolunteerThree.Models;
using Microsoft.AspNetCore.Http;


namespace VolunteerThree.Controllers
{
    public class VolunteersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VolunteersController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Volunteers
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Volunteers.Include(e => e.Zon).ToListAsync());

        }

        public async Task<IActionResult> VolunteerList()
        {

            string userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers.Include(e => e.Zon)
                .Where(m => m.UserId == userId).FirstOrDefaultAsync();

            if (volunteer == null)
            {
                return NotFound();
            }

            return View("Details", volunteer);

            //return View(await _context.Volunteers.Include(e => e.Zon).ToListAsync());


            //return View(await _context.Volunteers
            //    .Include(e => e.Zon)
            //    .FirstOrDefaultAsync(m => m.ZonId == id)
            //    .ToListAsync()); 

        }

        // GET: Volunteers/Details/5
        [Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> DetailsOfVolunteer()
        {
            string userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers.Include(e => e.Zon)
                .Where(m => m.UserId == userId).FirstOrDefaultAsync();

            if (volunteer == null)
            {
                return NotFound();
            }

            return View("Details", volunteer);
        }


        // GET: Volunteers/Details/5
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers.Include(e => e.Zon)
                .FirstOrDefaultAsync(m => m.VId == id);

            if (volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }

        // GET: Volunteers/Create
        [Authorize(Roles = "Admin, User")]
        public IActionResult Create()
        {
            List<Reg> list = _context.Regs.Include(e => e.zons).ToList();
            ViewBag.Region = list;
            return View();
        }



        // POST: Volunteers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VId,VSurname,VName,VBirthday,VPersonNumber,ZonId,VPhoneNumber,Note")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                volunteer.UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                _context.Add(volunteer);
                await _context.SaveChangesAsync();
                //return RedirectPermanent("/Home/Index");
                return RedirectToAction("Details", new { id = volunteer.VId });
            }
            List<Reg> list = _context.Regs.Include(e => e.zons).ToList();
            ViewBag.Region = list;
            return View(volunteer);
        }

        public async Task<IActionResult> EditList(int? id)
        {
            //string userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (id == null)
            {
                return NotFound();
            }

            var volunteers = await _context.Volunteers.FindAsync(id);
            if (volunteers == null)
            {
                return NotFound();
            }
            List<Reg> list = _context.Regs.Include(e => e.zons).ToList();
            ViewBag.Region = list;
            return View(volunteers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditList(int id, [Bind("VId,VSurname,VName,VBirthday,VPersonNumber,ZonId,VPhoneNumber,Note")] Volunteer volunteer)
        {

            if (id != volunteer.VId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    volunteer.UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    _context.Update(volunteer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VolunteerExists(volunteer.VId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new { id = id });
            }
            List<Reg> list = _context.Regs.Include(e => e.zons).ToList();
            ViewBag.Region = list;
            return View("Index", volunteer);
        }


        // GET: Volunteers/Edit/5
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Edit(int? id)
        {
            string userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (userId == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers.Include(e => e.Zon)
                .Where(m => m.UserId == userId)
                .FirstOrDefaultAsync();
            if (volunteer == null)
            {
                return NotFound();
            }
            List<Reg> list = _context.Regs.Include(e => e.zons).ToList();
            ViewBag.Region = list;
            return View(volunteer);
        }

        // POST: Volunteers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VId,VSurname,VName,VBirthday,VPersonNumber,ZonId,VPhoneNumber,Note")] Volunteer volunteer)
        {

            if (id != volunteer.VId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    volunteer.UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    _context.Update(volunteer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VolunteerExists(volunteer.VId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = id });
            }
            List<Reg> list = _context.Regs.Include(e => e.zons).ToList();
            ViewBag.Region = list;
            return View("Details", volunteer);
        }

       

        // GET: Volunteers/Delete/5
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteers.Include(e => e.Zon)
                .FirstOrDefaultAsync(m => m.VId == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }

        // POST: Volunteers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var volunteer = await _context.Volunteers.FindAsync(id);
            _context.Volunteers.Remove(volunteer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VolunteerExists(int id)
        {
            return _context.Volunteers.Any(e => e.VId == id);
        }
    }
}
