using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using deneme12.Models;
using deneme12.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Controllers
{

    public class DersProgramiController : Controller
    {
        private readonly IDersProgamiRepostory _dersProgamiRepostory;
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        private readonly ISinifRepostory _sinifRepostory;
        public DersProgramiController(ISinifRepostory sinifRepostory, IDersProgamiRepostory dersProgamiRepostory, IDersProgramiListRepostory programiListRepostory)
        {
            _dersProgamiRepostory = dersProgamiRepostory;
            _dersProgramiListRepostory = programiListRepostory;
            _sinifRepostory = sinifRepostory;
        }

        public IActionResult Index(int? sinifId)
        {


            ViewBag.SinifId = sinifId;

            return View();
        }
        public IActionResult AtaDersProgrami()
        {
            using var context = new AppDbContext();
            var sinifList = context.Sinif;
           

          
               
         
           
            return View();
        }
        [HttpPost]
        public IActionResult AtaDersProgrami(List<DersprogramiAtaModel> list)
        {
           
            return RedirectToAction("Index");



        }
    }
}
