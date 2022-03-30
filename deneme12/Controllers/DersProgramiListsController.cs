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
    public class DersProgramiListsController : Controller
    {
        private readonly AppDbContext _context;

        public DersProgramiListsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DersProgramiLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.DersProgramiList.ToListAsync());
        }

        // GET: DersProgramiLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgramiList = await _context.DersProgramiList
                .FirstOrDefaultAsync(m => m.DersProgramiListId == id);
            if (dersProgramiList == null)
            {
                return NotFound();
            }

            return View(dersProgramiList);
        }

        // GET: DersProgramiLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DersProgramiLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DersProgramiListId,Saat,DersProgramiListName")] DersProgramiList dersProgramiList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dersProgramiList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dersProgramiList);
        }

        // GET: DersProgramiLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgramiList = await _context.DersProgramiList.FindAsync(id);
            if (dersProgramiList == null)
            {
                return NotFound();
            }
            return View(dersProgramiList);
        }

        // POST: DersProgramiLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DersProgramiListId,Saat,DersProgramiListName")] DersProgramiList dersProgramiList)
        {
            if (id != dersProgramiList.DersProgramiListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dersProgramiList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DersProgramiListExists(dersProgramiList.DersProgramiListId))
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
            return View(dersProgramiList);
        }

        // GET: DersProgramiLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersProgramiList = await _context.DersProgramiList
                .FirstOrDefaultAsync(m => m.DersProgramiListId == id);
            if (dersProgramiList == null)
            {
                return NotFound();
            }

            return View(dersProgramiList);
        }

        // POST: DersProgramiLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dersProgramiList = await _context.DersProgramiList.FindAsync(id);
            _context.DersProgramiList.Remove(dersProgramiList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DersProgramiListExists(int id)
        {
            return _context.DersProgramiList.Any(e => e.DersProgramiListId == id);
        }
    }
}
