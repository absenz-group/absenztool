using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AbsenzAPPDBHosting.Data;
using AbsenzAPPDBHosting.Models;

namespace AbsenzAPPDBHosting.Controllers
{
    public class AbsenzensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AbsenzensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Absenzens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Absenzen.ToListAsync());
        }

        // GET: Absenzens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var absenzen = await _context.Absenzen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (absenzen == null)
            {
                return NotFound();
            }

            return View(absenzen);
        }

        // GET: Absenzens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Absenzens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Schueler,Datum,Absenzgrund,Lehrer,Modul")] Absenzen absenzen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(absenzen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(absenzen);
        }

        // GET: Absenzens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var absenzen = await _context.Absenzen.FindAsync(id);
            if (absenzen == null)
            {
                return NotFound();
            }
            return View(absenzen);
        }

        // POST: Absenzens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Schueler,Datum,Absenzgrund,Lehrer,Modul")] Absenzen absenzen)
        {
            if (id != absenzen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(absenzen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AbsenzenExists(absenzen.Id))
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
            return View(absenzen);
        }

        // GET: Absenzens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var absenzen = await _context.Absenzen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (absenzen == null)
            {
                return NotFound();
            }

            return View(absenzen);
        }

        // POST: Absenzens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var absenzen = await _context.Absenzen.FindAsync(id);
            if (absenzen != null)
            {
                _context.Absenzen.Remove(absenzen);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AbsenzenExists(int id)
        {
            return _context.Absenzen.Any(e => e.Id == id);
        }
    }
}
