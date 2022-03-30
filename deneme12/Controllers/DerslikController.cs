using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using deneme12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.Controllers
{
    public class DerslikController : Controller
    {
        private readonly IOgrenciRepostory _ogrenciRepostory;

        private readonly IVeliRepostory _veliRepostory;
        private readonly IDerslikRepostory _derslikRepostory;
        public DerslikController(IOgrenciRepostory ogrenciRepostory, IVeliRepostory veliRepostory, IDerslikRepostory derslikRepostory)
        {
            _ogrenciRepostory = ogrenciRepostory;

            _veliRepostory = veliRepostory;
            _derslikRepostory = derslikRepostory;
        }

        public IActionResult Index()
        {
         
                return View(_derslikRepostory.GetirHepsi());
          

        }
        public IActionResult Ekle()
        {

            return View(new DerslikEkleModel());
        }
        [HttpPost]
        public IActionResult Ekle(DerslikEkleModel model)
        {
            if (ModelState.IsValid)
            {
                Derslik derslik = new Derslik();
               

                derslik.DerslikName = model.DerslikName;
                
                _derslikRepostory.Ekle(derslik);
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult Guncelle(int id)
        {
            var gelenDerslik = _derslikRepostory.GetirIdile(id);



            DerslikGuncelleModel model = new DerslikGuncelleModel

            {
                DerslikName = gelenDerslik.DerslikName,
               

                DerslikId = gelenDerslik.DerslikId,

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Guncelle(DerslikGuncelleModel model)
        {

            if (ModelState.IsValid)
            {
                var guncelleDerslik = _derslikRepostory.GetirIdile(model.DerslikId);


                guncelleDerslik.DerslikName = model.DerslikName;
                

                _derslikRepostory.Güncelle(guncelleDerslik);
                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}
