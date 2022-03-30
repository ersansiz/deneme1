using deneme12.Context;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace deneme12.ViewComponents
{
    
    public class NavList : ViewComponent
    {
        private readonly AppDbContext _context;
        public NavList(AppDbContext context)
        {

            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewData["DersId"] = new SelectList(_context.Ders, "DersId", "DersName");
            ViewData["DerslikId"] = new SelectList(_context.Dersliks, "DerslikId", "DerslikName");
            ViewData["GunId"] = new SelectList(_context.Gun, "GunId", "GunName");
            ViewData["SinifId"] = new SelectList(_context.Sinif, "SinifId", "SinifName");
            return View();
        }
    }
}
