using deneme12.Context;
using deneme12.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.Controllers
{
    public class DerslikAta : Controller
    {
        private AppDbContext _context;
        public DerslikAta(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("DerslikAtama");
        }
        [HttpGet]
        public IActionResult DerslikAtama(int id)
        {
            var sinif = _context.Sinif.Find(id);
            ViewBag.derslik = _context.Dersliks.Include(p => p.DerslikSinif);
            return View("DerslikEditor", sinif);
        }
        [HttpPost]
        public IActionResult DerslikAtama(int id, int[] derslikid)
        {
            Sinif sinif = _context
                .Sinif
                .Include(s => s.DerslikSinif)
                .First(i => i.SinifId == id);

            if (sinif != null)
            {
                sinif.DerslikSinif = derslikid.Select(sid => new DerslikSinif()
                {
                    DerslikID = sid,
                    SinifId = sinif.SinifId
                }).ToList();
                _context.SaveChanges();
            }
            return RedirectToAction("Index","Sinif");
        }
    }
}
