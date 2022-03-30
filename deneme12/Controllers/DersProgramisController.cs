using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using deneme12.Context;
using deneme12.Entity;
using deneme12.ViewModels;
using deneme12.Repostories;
using deneme12.Interfaces;

namespace deneme12.Controllers
{
    public class DersProgramisController : Controller 
    {
        private readonly AppDbContext _db;
        private readonly IDersProgamiRepostory _dersProgamiRepostory;
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;

        public DersProgramisController(AppDbContext db, IDersProgamiRepostory dersProgamiRepostory, IDersProgramiListRepostory dersProgramiListRepostory)
        {
            _db = db;
            _dersProgamiRepostory = dersProgamiRepostory;
            _dersProgramiListRepostory= dersProgramiListRepostory;
        }

        // GET: DersProgramis
        public IActionResult Index(int? sinifId, int? gunId,int? derslikId,int? dersId)
        {
            if (sinifId==null && gunId==null && derslikId==null && dersId==null )
            {

             
                return View( _dersProgramiListRepostory.GetirHepsi());

            }
            else if(sinifId!= null && gunId == null && derslikId==null && dersId==null)
            {
                DersProgramiListVm dersProgrami = new DersProgramiListVm
                {

                    DersProgramiList = _dersProgramiListRepostory.GetirSinifIdile((int)sinifId),

                };
                return View(dersProgrami);


            }
            else if (sinifId == null && gunId!= null && derslikId == null && dersId==null)
            {

                DersProgramiListVm dersProgrami = new DersProgramiListVm
                {

                    DersProgramiList = _dersProgramiListRepostory.GetirGunIdile((int)gunId),

                };
                return View(dersProgrami);
            }
            else if (sinifId == null && gunId == null && derslikId!= null && dersId==null)
            {

                DersProgramiListVm dersProgrami = new DersProgramiListVm
                {

                    DersProgramiList = _dersProgramiListRepostory.GetirDerslikIdile((int)derslikId),

                };
                return View(dersProgrami);
            }
            else if (sinifId == null && gunId == null && derslikId == null && dersId != null)
            {

                DersProgramiListVm dersProgrami = new DersProgramiListVm
                {

                    DersProgramiList = _dersProgramiListRepostory.GetirDersIdile((int)dersId),

                };
                return View(dersProgrami);
            }
            else
            {
                return View();
            }

      

        }

        // GET: DersProgramis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgrami = await _db.DersProgrami
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

        // GET: DersProgramis/Create
        public IActionResult Create()
        {
            ViewData["DersId"] = new SelectList(_db.Ders, "DersId", "DersName");
            ViewData["DersProgramiListId"] = new SelectList(_db.DersProgramiList, "DersProgramiListId", "DersProgramiListId");
            ViewData["DerslikId"] = new SelectList(_db.Dersliks, "DerslikId", "DerslikName");
            ViewData["GunId"] = new SelectList(_db.Gun, "GunId", "GunName");
            ViewData["SinifId"] = new SelectList(_db.Sinif, "SinifId", "SinifName");
            ViewData["SaatId"] = new SelectList(_db.Saat, "SaatId", "SaatName");
            return View();
        }

        // POST: DersProgramis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DersProgramiId,DersProgramiListId,SaatId,SinifId,GunId,DerslikId,DersId")] DersProgrami dersProgrami)
        {
            if (ModelState.IsValid)
            {
                _db.Add(dersProgrami);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DersId"] = new SelectList(_db.Ders, "DersId", "DersId", dersProgrami.DersId);
            ViewData["DersProgramiListId"] = new SelectList(_db.DersProgramiList, "DersProgramiListId", "DersProgramiListId", dersProgrami.DersProgramiListId);
            ViewData["DerslikId"] = new SelectList(_db.Dersliks, "DerslikId", "DerslikId", dersProgrami.DerslikId);
            ViewData["GunId"] = new SelectList(_db.Gun, "GunId", "GunId", dersProgrami.GunId);
            ViewData["SinifId"] = new SelectList(_db.Sinif, "SinifId", "SinifId", dersProgrami.SinifId);
            ViewData["SaatId"] = new SelectList(_db.Saat, "SaatId", "SaatId", dersProgrami.SaatId);
            return View(dersProgrami);
        }

        // GET: DersProgramis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgrami = await _db.DersProgrami.FindAsync(id);
            if (dersProgrami == null)
            {
                return NotFound();
            }
            ViewData["DersId"] = new SelectList(_db.Ders, "DersId", "DersName", dersProgrami.DersId);
            ViewData["DersProgramiListId"] = new SelectList(_db.DersProgramiList, "DersProgramiListId", "DersProgramiListId", dersProgrami.DersProgramiListId);
            ViewData["DerslikId"] = new SelectList(_db.Dersliks, "DerslikId", "DerslikName", dersProgrami.DerslikId);
            ViewData["GunId"] = new SelectList(_db.Gun, "GunId", "GunName", dersProgrami.GunId);
            ViewData["SinifId"] = new SelectList(_db.Sinif, "SinifId", "SinifName", dersProgrami.SinifId);
            ViewData["SaatId"] = new SelectList(_db.Saat, "SaatId", "SaatId", dersProgrami.SaatId);
            return View(dersProgrami);
        }

        // POST: DersProgramis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DersProgramiId,DersProgramiListId,Saat,SinifId,GunId,DerslikId,DersId")] DersProgrami dersProgrami)
        {
            if (id != dersProgrami.DersProgramiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(dersProgrami);
                    await _db.SaveChangesAsync();
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
            ViewData["DersId"] = new SelectList(_db.Ders, "DersId", "DersId", dersProgrami.DersId);
            ViewData["DersProgramiListId"] = new SelectList(_db.DersProgramiList, "DersProgramiListId", "DersProgramiListId", dersProgrami.DersProgramiListId);
            ViewData["DerslikId"] = new SelectList(_db.Dersliks, "DerslikId", "DerslikId", dersProgrami.DerslikId);
            ViewData["GunId"] = new SelectList(_db.Gun, "GunId", "GunId", dersProgrami.GunId);
            ViewData["SinifId"] = new SelectList(_db.Sinif, "SinifId", "SinifId", dersProgrami.SinifId);
            ViewData["SaatId"] = new SelectList(_db.Saat, "SaatId", "SaatId", dersProgrami.SaatId);
            return View(dersProgrami);
        }

        // GET: DersProgramis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["DersId"] = new SelectList(_db.Ders, "DersId", "DersName");
            ViewData["DersProgramiListId"] = new SelectList(_db.DersProgramiList, "DersProgramiListId", "DersProgramiListId");
            ViewData["DerslikId"] = new SelectList(_db.Dersliks, "DerslikId", "DerslikName");
            ViewData["GunId"] = new SelectList(_db.Gun, "GunId", "GunName");
            ViewData["SinifId"] = new SelectList(_db.Sinif, "SinifId", "SinifName");
            ViewData["SaatId"] = new SelectList(_db.Saat, "SaatId", "SaatId");
            if (id == null)
            {
                return NotFound();
            }

            var dersProgrami = await _db.DersProgrami
                .Include(d => d.Ders)
                .Include(d => d.DersProgramiList)
                .Include(d => d.Derslik)
                .Include(d => d.Gun)
                .Include(d => d.Sinif)
                .Include(d => d.Saat)
                .FirstOrDefaultAsync(m => m.DersProgramiId == id);
            if (dersProgrami == null)
            {
                return NotFound();
            }

            return View(dersProgrami);
        }

        // POST: DersProgramis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dersProgrami = await _db.DersProgrami.FindAsync(id);
            _db.DersProgrami.Remove(dersProgrami);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DersProgramiExists(int id)
        {
            return _db.DersProgrami.Any(e => e.DersProgramiId == id);
        }
    }
}
