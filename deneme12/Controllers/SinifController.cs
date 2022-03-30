using deneme12.Interfaces;
using deneme12.Models;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.Controllers
{
    public class SinifController : Controller
    {
        private readonly ISinifRepostory _sinifRepostory;
        public SinifController(ISinifRepostory sinifRepostory)
        {
            _sinifRepostory = sinifRepostory;
        }
        public IActionResult Index()
        {
            return View(_sinifRepostory.GetirHepsi());
        }
        public IActionResult Ekle()
        {
            return View(new SinifEkleModel());
        }
        [HttpPost]
        public IActionResult Ekle(SinifEkleModel model)
        {
            if (ModelState.IsValid)
            {
                _sinifRepostory.Ekle(new Entity.Sinif
                {
                    SinifName = model.SinifName,
                    
                });
                return RedirectToAction("Index");   
            }
            return View(model);
        }
        public IActionResult Guncelle(int Id)
        {
            var guncellesinif = _sinifRepostory.GetirIdile(Id);
            SinifGuncelleModel model = new SinifGuncelleModel
            {
                Id = guncellesinif.SinifId,
                SinifName =guncellesinif.SinifName,
               

            
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Guncelle(SinifGuncelleModel model)
        {
            if (ModelState.IsValid)
            { 
            var guncellesinif = _sinifRepostory.GetirIdile(model.Id);
                guncellesinif.SinifName = model.SinifName;
                
                _sinifRepostory.Güncelle(guncellesinif);
                return RedirectToAction("Index");
                    }
            return View(model);
        }
        public IActionResult Sil(int Id)
        {
            _sinifRepostory .Sil(new Entity.Sinif { SinifId= Id });

            return RedirectToAction("Index");
        }
      
    }
}
