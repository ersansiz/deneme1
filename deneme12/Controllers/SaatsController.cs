using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using deneme12.Context;
using deneme12.Entity;

namespace deneme12.Controllers
{
    public class SaatsController : Controller
    {
        private readonly AppDbContext _context;

        public SaatsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Saats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saat.ToListAsync());
        }

        // GET: Saats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saat = await _context.Saat
                .FirstOrDefaultAsync(m => m.SaatId == id);
            if (saat == null)
            {
                return NotFound();
            }

            return View(saat);
        }

        // GET: Saats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Saats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SaatId,SaatName")] Saat saat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saat);
        }

        // GET: Saats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saat = await _context.Saat.FindAsync(id);
            if (saat == null)
            {
                return NotFound();
            }
            return View(saat);
        }

        // POST: Saats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SaatId,SaatName")] Saat saat)
        {
            if (id != saat.SaatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaatExists(saat.SaatId))
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
            return View(saat);
        }

        // GET: Saats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saat = await _context.Saat
                .FirstOrDefaultAsync(m => m.SaatId == id);
            if (saat == null)
            {
                return NotFound();
            }

            return View(saat);
        }

        // POST: Saats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saat = await _context.Saat.FindAsync(id);
            _context.Saat.Remove(saat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaatExists(int id)
        {
            return _context.Saat.Any(e => e.SaatId == id);
        }
    }
}
