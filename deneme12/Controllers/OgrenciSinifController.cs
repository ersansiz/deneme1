using deneme12.Context;
using deneme12.Models;
using deneme12.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.Controllers
{
    public class OgrenciSinifController : Controller
    {
        private AppDbContext _context;
        public OgrenciSinifController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            var model = new OgrenciAtaModel();
            model.Sinif = _context.Sinif
                .Include(i => i.OgrenciSinif)
                .ThenInclude(i => i.Ogrenci)
                .ToList();
            model.Ogrenci = _context.Ogrenci
                .Include(i => i.OgrenciSinif)
                .ThenInclude(i => i.Sinif)
               
                .ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult EditOgrenci (int id)
        {
            var ogrenci = _context.Ogrenci.Find(id);
            ViewBag.Sinif= _context.Sinif.Include(p=>p.OgrenciSinif);
            return View("OgrenciEditor", ogrenci);
        }
        [HttpPost]
        public IActionResult EditOgrenci(int id,int[] sinifid)
        {
            Ogrenci ogrenci = _context
                .Ogrenci
                .Include(s => s.OgrenciSinif)
                .First(i => i.OgrenciID== id);

            if (ogrenci!=null)
            {
                ogrenci.OgrenciSinif = sinifid.Select(sid => new OgrenciSinif()
                {
                    SinifID=sid,
                    OgrenciId=ogrenci.OgrenciID 
                }).ToList();
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult VeliAta(int id)
        {
            var ogrenci = _context.Ogrenci.Find(id);
            ViewBag.Veli = _context.Veli.Include(p => p.OgrenciVeli);
            return View("VeliEditor", ogrenci);
        }
        [HttpPost]
        public IActionResult VeliAta(int id, int[] veliid)
        {
            Ogrenci ogrenci = _context
                .Ogrenci
                .Include(s => s.OgrenciVeli)
                .First(i => i.OgrenciID == id);

            if (ogrenci != null)
            {
                ogrenci.OgrenciVeli = veliid.Select(sid => new OgrenciVeli()
                {
                    VeliID = sid,
                    OgrenciId = ogrenci.OgrenciID
                }).ToList();
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
      
    }
}
