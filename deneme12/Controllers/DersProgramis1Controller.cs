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
    public class DersProgramis1Controller : Controller
    {
        private readonly AppDbContext _context;

        public DersProgramis1Controller(AppDbContext context)
        {
            _context = context;
        }

        // GET: DersProgramis1
        public IActionResult Index(int? sinifId, int? gunId, int? derslikId, int? dersId, int? saatId,string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var appDbContext = _context.DersProgrami
                   .Include(d => d.Ders).Include(d => d.DersProgramiList).Include(d => d.Derslik).Include(d => d.Gun).Include(d => d.Saat).Include(d => d.Sinif)
                   .Where(I => I.Sinif.SinifName.ToLower().Contains(search.ToLower()))
                   .ToList();
                return View(appDbContext);
            }
            if (sinifId == null && gunId == null && derslikId == null && dersId == null && saatId == null)
            {
                var appDbContext = _context.DersProgrami.Include(d => d.Ders).Include(d => d.DersProgramiList).Include(d => d.Derslik).Include(d => d.Gun).Include(d => d.Saat).Include(d => d.Sinif);
                return View(appDbContext.ToList());
            }
         
            else if (sinifId != null && gunId == null && derslikId == null && dersId == null && saatId == null)
            {
                var appDbContext = _context.DersProgrami
                    .Include(d => d.Ders).Include(d => d.DersProgramiList).Include(d => d.Derslik).Include(d => d.Gun).Include(d => d.Saat).Include(d => d.Sinif)
                    .Where(I => I.SinifId == sinifId)
                    .ToList();
                return View(appDbContext);


            }
            else if (sinifId == null && gunId != null && derslikId == null && dersId == null && saatId == null)
            {

                var appDbContext = _context.DersProgrami
                      .Include(d => d.Ders).Include(d => d.DersProgramiList).Include(d => d.Derslik).Include(d => d.Gun).Include(d => d.Saat).Include(d => d.Sinif)
                      .Where(I => I.GunId == gunId)
                      .ToList();
                return View(appDbContext);
            }
            else if (sinifId == null && gunId == null && derslikId != null && dersId == null && saatId == null)
            {

                var appDbContext = _context.DersProgrami
                   .Include(d => d.Ders).Include(d => d.DersProgramiList).Include(d => d.Derslik).Include(d => d.Gun).Include(d => d.Saat).Include(d => d.Sinif)
                   .Where(I => I.DerslikId == derslikId)
                   .ToList();
                return View(appDbContext);
            }
            else if (sinifId == null && gunId == null && derslikId == null && dersId != null && saatId == null)
            {

                var appDbContext = _context.DersProgrami
                    .Include(d => d.Ders).Include(d => d.DersProgramiList).Include(d => d.Derslik).Include(d => d.Gun).Include(d => d.Saat).Include(d => d.Sinif)
                    .Where(I => I.DersId == dersId)
                    .ToList();
                return View(appDbContext);
            }
            else if (sinifId == null && gunId == null && derslikId == null && dersId == null && saatId != null)
            {

                var appDbContext = _context.DersProgrami
                    .Include(d => d.Ders).Include(d => d.DersProgramiList).Include(d => d.Derslik).Include(d => d.Gun).Include(d => d.Saat).Include(d => d.Sinif)
                    .Where(I => I.SaatId == saatId)
                    .ToList();
                return View(appDbContext);
            }
            else
            {
                return View();
            }
        }

        // GET: DersProgramis1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgrami = await _context.DersProgrami
                .Include(d => d.Ders)
                .Include(d => d.DersProgramiList)
                .Include(d => d.Derslik)
                .Include(d => d.Gun)
                .Include(d => d.Saat)
                .Include(d => d.Sinif)
                .FirstOrDefaultAsync(m => m.DersProgramiId == id);
            if (dersProgrami == null)
            {
                return NotFound();
            }

            return View(dersProgrami);
        }

        // GET: DersProgramis1/Create
        public IActionResult Create()
        {
            ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersName");
            ViewData["DersProgramiListId"] = new SelectList(_context.DersProgramiList, "DersProgramiListId", "DersProgramiListName");
            ViewData["DerslikId"] = new SelectList(_context.Dersliks, "DerslikId", "DerslikName");
            ViewData["GunId"] = new SelectList(_context.Gun, "GunId", "GunName");
            ViewData["SaatId"] = new SelectList(_context.Saat, "SaatId", "SaatName");
            ViewData["SinifId"] = new SelectList(_context.Sinif, "SinifId", "SinifName");
            return View();
        }

        // POST: DersProgramis1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DersProgramiId,DersProgramiListId,SinifId,SaatId,GunId,DerslikId,DersId")] DersProgrami dersProgrami)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dersProgrami);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersId", dersProgrami.DersId);
            ViewData["DersProgramiListId"] = new SelectList(_context.DersProgramiList, "DersProgramiListId", "DersProgramiListId", dersProgrami.DersProgramiListId);
            ViewData["DerslikId"] = new SelectList(_context.Dersliks, "DerslikId", "DerslikId", dersProgrami.DerslikId);
            ViewData["GunId"] = new SelectList(_context.Gun, "GunId", "GunId", dersProgrami.GunId);
            ViewData["SaatId"] = new SelectList(_context.Saat, "SaatId", "SaatId", dersProgrami.SaatId);
            ViewData["SinifId"] = new SelectList(_context.Sinif, "SinifId", "SinifId", dersProgrami.SinifId);
            return View(dersProgrami);
        }

        // GET: DersProgramis1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgrami = await _context.DersProgrami.FindAsync(id);
            if (dersProgrami == null)
            {
                return NotFound();
            }
            ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersName", dersProgrami.DersId);
            ViewData["DersProgramiListId"] = new SelectList(_context.DersProgramiList, "DersProgramiListId", "DersProgramiListId", dersProgrami.DersProgramiListId);
            ViewData["DerslikId"] = new SelectList(_context.Dersliks, "DerslikId", "DerslikName", dersProgrami.DerslikId);
            ViewData["GunId"] = new SelectList(_context.Gun, "GunId", "GunName", dersProgrami.GunId);
            ViewData["SaatId"] = new SelectList(_context.Saat, "SaatId", "SaatNAme", dersProgrami.SaatId);
            ViewData["SinifId"] = new SelectList(_context.Sinif, "SinifId", "SinifName", dersProgrami.SinifId);
            return View(dersProgrami);
        }

        // POST: DersProgramis1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DersProgramiId,DersProgramiListId,SinifId,SaatId,GunId,DerslikId,DersId")] DersProgrami dersProgrami)
        {
            if (id != dersProgrami.DersProgramiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dersProgrami);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DersProgramiExists(dersProgrami.DersProgramiId))
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
            ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersId", dersProgrami.DersId);
            ViewData["DersProgramiListId"] = new SelectList(_context.DersProgramiList, "DersProgramiListId", "DersProgramiListId", dersProgrami.DersProgramiListId);
            ViewData["DerslikId"] = new SelectList(_context.Dersliks, "DerslikId", "DerslikId", dersProgrami.DerslikId);
            ViewData["GunId"] = new SelectList(_context.Gun, "GunId", "GunId", dersProgrami.GunId);
            ViewData["SaatId"] = new SelectList(_context.Saat, "SaatId", "SaatId", dersProgrami.SaatId);
            ViewData["SinifId"] = new SelectList(_context.Sinif, "SinifId", "SinifId", dersProgrami.SinifId);
            return View(dersProgrami);
        }

        // GET: DersProgramis1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgrami = await _context.DersProgrami
                .Include(d => d.Ders)
                .Include(d => d.DersProgramiList)
                .Include(d => d.Derslik)
                .Include(d => d.Gun)
                .Include(d => d.Saat)
                .Include(d => d.Sinif)
                .FirstOrDefaultAsync(m => m.DersProgramiId == id);
            if (dersProgrami == null)
            {
                return NotFound();
            }

            return View(dersProgrami);
        }

        // POST: DersProgramis1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dersProgrami = await _context.DersProgrami.FindAsync(id);
            _context.DersProgrami.Remove(dersProgrami);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DersProgramiExists(int id)
        {
            return _context.DersProgrami.Any(e => e.DersProgramiId == id);
        }
    }
}
