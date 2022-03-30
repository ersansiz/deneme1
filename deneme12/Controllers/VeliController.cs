using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using deneme12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.Controllers
{
    public class VeliController : Controller
    {
       
        private AppDbContext _context;
      
        public VeliController(AppDbContext context)
        {
            _context = context;
        }
      
        public IActionResult Index()
        {
            var model = new VeliAtaModel();
            model.Veli = _context.Veli
                .Include(i => i.OgrenciVeli)
                .ThenInclude(i => i.Veli)
                .ToList();
            model.Ogrenci = _context.Ogrenci
                .Include(i => i.OgrenciVeli)
                .ThenInclude(i => i.Veli)

                .ToList();
            return View(model);
           
        }


       



    }
}
